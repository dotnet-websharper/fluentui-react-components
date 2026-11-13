namespace WebSharper.FluentUI.React.Components.Sample

open WebSharper
open WebSharper.JavaScript
open WebSharper.UI
open WebSharper.UI.Client
open WebSharper.UI.Templating
open WebSharper.React
open WebSharper.FluentUI.React

[<JavaScript>]
module Client =

    // The Fluent UI helpers are kept in their own module so that e.g.
    // `F.text` (the Fluent `Text` component) does not clash with
    // `Html.text` (a plain HTML text node).
    module F = WebSharper.FluentUI.React.Helpers

    // The template is the whole document, loaded from the DOM, so editing
    // index.html and refreshing the browser is enough.
    type IndexTemplate = Template<"index.html", ClientLoad.FromDocument>

    /// Keep in sync with the `@fluentui/react-components` version pinned in
    /// WebSharper.React.FluentUi.Components.fsproj and package.json.
    let fluentVersion = "9.75.2"

    /// A self-contained placeholder image so the sample needs no network access.
    let private imageDataUri =
        "data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' width='160' height='90'%3E" +
        "%3Cdefs%3E%3ClinearGradient id='g' x1='0' y1='0' x2='1' y2='1'%3E" +
        "%3Cstop offset='0' stop-color='%230078d4'/%3E%3Cstop offset='1' stop-color='%2300b7c3'/%3E" +
        "%3C/linearGradient%3E%3C/defs%3E%3Crect width='160' height='90' fill='url(%23g)'/%3E" +
        "%3Ctext x='80' y='52' font-family='Segoe UI, sans-serif' font-size='16' fill='white' text-anchor='middle'%3EFluent UI%3C/text%3E%3C/svg%3E"

    let themeKey = "websharper-fluentui-theme"
    let theme = Var.Create "light"
    let themeLabel = Var.Create "🌙 Dark mode"
    let status = Var.Create ""
    let reactVersion = Var.Create "-"

    /// A Fluent UI prop. The binding's helpers take `seq<string * obj>`.
    let private prop (k: string) (v: obj) = (k, v)

    // The Fluent theme lives inside the React tree, so the page-level toggle
    // talks to it through this hook, wired up when the tree mounts.
    let mutable private setFluentDark : (bool -> unit) option = None

    let applyTheme () =
        JS.Document.DocumentElement.SetAttribute("data-theme", theme.Value)
        themeLabel.Value <-
            if theme.Value = "dark" then "☀️ Light mode" else "🌙 Dark mode"
        setFluentDark |> Option.iter (fun setDark -> setDark (theme.Value = "dark"))

    let toggleTheme () =
        theme.Value <- (if theme.Value = "dark" then "light" else "dark")
        try JS.Window.LocalStorage.SetItem(themeKey, theme.Value) with _ -> ()
        applyTheme ()

    // ------------------------------------------------------------------
    // A tiny error boundary so one broken component cannot blank the page.
    // ------------------------------------------------------------------

    type BoundaryProps = { title: string; content: React.Element }
    type BoundaryState = { failed: bool }

    type Boundary(props) as this =
        inherit React.Component<BoundaryProps, BoundaryState>(props)

        do this.SetInitialState { failed = false }

        override this.ComponentDidCatch(_error, _info) =
            this.SetState { failed = true }

        override this.Render() =
            if this.State.failed then
                Html.div [ Html.attr.className "section-error" ] [
                    Html.text (this.Props.title + " could not be rendered.")
                ]
            else
                this.Props.content

    let private guard title (content: React.Element) =
        ReactHelpers.Make Boundary { title = title; content = content }

    // ------------------------------------------------------------------
    // Showcase sections
    // ------------------------------------------------------------------

    let private section (title: string) (children: React.Element list) =
        Html.section [ Html.attr.className "section" ] [
            Html.h2 [ Html.attr.className "section-title" ] [ Html.text title ]
            Html.div [ Html.attr.className "section-body" ] children
        ]

    let private stack (children: React.Element list) =
        Html.div [ Html.attr.className "section-stack" ] children

    /// The `on.*` helpers return `(string * obj)` props, so they can be mixed
    /// with the Fluent-specific props above.
    let private Buttons () =
        section "Buttons" [
            F.button [ prop "appearance" "primary" ] [ Html.text "Primary" ]
            F.button [ prop "appearance" "secondary" ] [ Html.text "Secondary" ]
            F.button [ prop "appearance" "subtle" ] [ Html.text "Subtle" ]
            F.compoundButton [ prop "secondaryContent" "with a description" ] [ Html.text "Compound" ]
            F.toggleButton [ prop "defaultChecked" true ] [ Html.text "Toggle" ]
            F.link [ prop "href" "https://websharper.com" ] [ Html.text "A link" ]
            F.menuButton [ prop "disableButtonEnhancement" true ] [ Html.text "Menu button" ]
            F.splitButton [ prop "disableButtonEnhancement" true ] [ Html.text "Split button" ]
        ]

    let private Badges () =
        section "Badges, avatars and personas" [
            F.badge [ prop "appearance" "filled"; prop "children" (Html.text "Badge") ]
            F.badge [ prop "appearance" "tint"; prop "color" "brand"; prop "children" (Html.text "Tinted") ]
            F.counterBadge [ prop "count" 7 ]
            F.presenceBadge [ prop "status" "available" ]
            F.presenceBadge [ prop "status" "busy" ]
            F.avatar [ prop "name" "Ada Lovelace" ]
            F.avatarGroup [] [
                F.avatar [ prop "name" "Ada Lovelace" ]
                F.avatar [ prop "name" "Grace Hopper" ]
                F.avatar [ prop "name" "Alan Turing" ]
            ]
            F.persona [
                prop "name" "Grace Hopper"
                prop "secondaryText" "Rear Admiral"
                prop "presence" (box {| status = "available" |})
                prop "avatar" (box {| name = "Grace Hopper" |})
            ]
        ]

    let private Cards () =
        section "Cards" [
            F.card [ prop "appearance" "outline"; prop "orientation" "vertical" ] [
                F.cardHeader [
                    prop "header" "Card header"
                    prop "description" "Rendered by CardHeader, CardPreview and CardFooter."
                ] []
                F.cardPreview [] [
                    Html.div [ Html.attr.className "card-preview" ] []
                ]
                F.cardFooter [] [
                    F.button [ prop "appearance" "primary" ] [ Html.text "Open" ]
                    F.button [ prop "appearance" "secondary" ] [ Html.text "Dismiss" ]
                ]
            ]
        ]

    let private Inputs () =
        let subscribed, setSubscribed = React.UseState false
        let notifyOn, setNotifyOn = React.UseState true
        section "Inputs and selection" [
            stack [
                F.field [ prop "label" "Name" ] [
                    F.input [ prop "placeholder" "Type your name" ]
                ]
                F.textarea [ prop "placeholder" "A comment" ] []
                F.dropdown [ prop "placeholder" "Pick one" ] [
                    F.option [ prop "value" "one" ] [ Html.text "One" ]
                    F.option [ prop "value" "two" ] [ Html.text "Two" ]
                ]
                F.combobox [ prop "placeholder" "Search..." ] [
                    F.option [ prop "value" "alpha" ] [ Html.text "Alpha" ]
                    F.option [ prop "value" "beta" ] [ Html.text "Beta" ]
                ]
                F.select [] [
                    F.option [ prop "value" "a" ] [ Html.text "Option A" ]
                    F.option [ prop "value" "b" ] [ Html.text "Option B" ]
                ]
                F.listbox [ prop "aria-label" "A listbox" ] [
                    F.option [ prop "value" "x" ] [ Html.text "Listbox X" ]
                    F.option [ prop "value" "y" ] [ Html.text "Listbox Y" ]
                ]
            ]
            stack [
                F.checkbox [
                    prop "label" "Subscribe to updates"
                    prop "checked" subscribed
                    Html.on.change (fun (_: WebSharper.React.SyntheticEvent) -> setSubscribed.Invoke (not subscribed))
                ] []
                F.switch [
                    prop "label" "Enable notifications"
                    prop "checked" notifyOn
                    Html.on.change (fun (_: WebSharper.React.SyntheticEvent) -> setNotifyOn.Invoke (not notifyOn))
                ]
                F.radioGroup [ prop "defaultValue" "b" ] [
                    F.radio [ prop "value" "a"; prop "label" "Radio A" ]
                    F.radio [ prop "value" "b"; prop "label" "Radio B" ]
                ]
            ]
            stack [
                F.slider [ prop "defaultValue" 30; prop "min" 0; prop "max" 100 ]
                F.spinButton [ prop "defaultValue" 5; prop "min" 0; prop "max" 10 ]
                F.progressBar [ prop "value" 0.6 ]
                F.spinner [ prop "label" "Working" ]
                F.skeleton [] [ F.skeletonItem [ prop "shape" "rectangle"; prop "size" 48 ] [] ]
                F.divider [] []
                F.image [ prop "src" imageDataUri; prop "alt" "A placeholder" ]
            ]
        ]

    let private Navigation () =
        section "Navigation" [
            guard "Breadcrumbs, tabs and accordion" (stack [
                F.breadcrumb [ prop "aria-label" "Breadcrumb" ] [
                    F.Breadcrumb.item [] [ F.Breadcrumb.button [] [ Html.text "Home" ] ]
                    F.Breadcrumb.divider [] []
                    F.Breadcrumb.item [] [ F.Breadcrumb.button [] [ Html.text "Library" ] ]
                ]
                F.tabList [ prop "defaultSelectedValue" "a" ] [
                    F.tab [ prop "value" "a" ] [ Html.text "First" ]
                    F.tab [ prop "value" "b" ] [ Html.text "Second" ]
                    F.tab [ prop "value" "c" ] [ Html.text "Third" ]
                ]
                F.accordion [ prop "collapsible" true ] [
                    F.accordionItem [ prop "value" "1" ] [
                        F.accordionHeader [] [ Html.text "Section one" ]
                        F.accordionPanel [] [ Html.text "The first panel." ]
                    ]
                    F.accordionItem [ prop "value" "2" ] [
                        F.accordionHeader [] [ Html.text "Section two" ]
                        F.accordionPanel [] [ Html.text "The second panel." ]
                    ]
                ]
            ])
            guard "Menu" (stack [
                F.menu [] [
                    F.Menu.trigger [ prop "disableButtonEnhancement" true ] [
                        F.button [] [ Html.text "Open menu" ]
                    ]
                    F.Menu.popover [] [
                        F.menuList [] [
                            F.Menu.item [] [ Html.text "New" ]
                            F.Menu.item [] [ Html.text "Open" ]
                            F.Menu.item [] [ Html.text "Save" ]
                        ]
                    ]
                ]
            ])
            guard "Toolbar" (stack [
                F.toolbar [ prop "aria-label" "Formatting" ] [
                    F.Toolbar.button [ prop "value" "b" ] [ Html.text "B" ]
                    F.Toolbar.divider [] []
                    F.Toolbar.toggleButton [ prop "name" "style"; prop "value" "i" ] [ Html.text "I" ]
                ]
            ])
            guard "Overflow" (stack [
                F.overflow [ prop "itemSize" 120; prop "padding" 8 ] [
                    Html.div [ Html.attr.className "overflow-row" ] [
                        F.overflowItem [ prop "id" "1"; prop "groupId" "g" ] [ F.button [] [ Html.text "Item one" ] ]
                        F.overflowItem [ prop "id" "2"; prop "groupId" "g" ] [ F.button [] [ Html.text "Item two" ] ]
                        F.overflowItem [ prop "id" "3"; prop "groupId" "g" ] [ F.button [] [ Html.text "Item three" ] ]
                    ]
                ]
            ])
        ]

    let private Surfaces () =
        section "Dialogs, drawers and popups" [
            F.dialog [] [
                F.Dialog.trigger [] [ F.button [] [ Html.text "Open dialog" ] ]
                F.Dialog.surface [] [
                    F.Dialog.body [] [
                        F.Dialog.title [] [ Html.text "A Fluent dialog" ]
                        F.Dialog.content [] [ Html.text "Dialogs render through a portal." ]
                        F.Dialog.actions [] [
                            F.button [ prop "appearance" "primary" ] [ Html.text "Close" ]
                        ]
                    ]
                ]
            ]
            F.inlineDrawer [ prop "type" "inline"; prop "separator" true; prop "open" true ] [
                F.Drawer.header [] [ F.Drawer.headerTitle [] [ Html.text "Drawer" ] ]
                F.divider [] []
                F.Drawer.body [] [ Html.text "Drawer content" ]
            ]
            F.popover [] [
                F.Popover.popoverTrigger [] [ F.button [] [ Html.text "Open popover" ] ]
                F.Popover.popoverSurface [] [ Html.text "Popover content" ]
            ]
            F.tooltip [ prop "content" "A helpful tooltip"; prop "relationship" "description" ] [
                F.button [] [ Html.text "Hover me" ]
            ]
            F.portal [] [ Html.text "" ]
        ]

    let private Status () =
        section "Message bars and tags" [
            stack [
                F.messageBar [ prop "intent" "success" ] [
                    F.MessageBar.body [] [
                        F.MessageBar.title [] [ Html.text "Saved" ]
                        Html.text "Your changes were saved successfully."
                    ]
                ]
                F.messageBar [ prop "intent" "warning" ] [
                    F.MessageBar.body [] [ Html.text "Something needs your attention." ]
                ]
            ]
            stack [
                F.tagGroup [ prop "aria-label" "Tags" ] [
                    F.tag [ prop "dismissible" true ] [ Html.text "Design" ]
                    F.tag [ prop "dismissible" true ] [ Html.text "Engineering" ]
                    F.interactionTag [] [
                        F.InteractionTag.primary [] [ Html.text "Interaction tag" ]
                    ]
                ]
                F.text [ prop "size" 300 ] [ Html.text "Fluent Text at size 300." ]
                F.infoLabel [ prop "info" "Extra context" ] [ Html.text "InfoLabel" ]
                F.label [ prop "required" true ] [ Html.text "Label" ]
            ]
        ]

    let private Data () =
        section "Tables and trees" [
            stack [
                F.table [ prop "aria-label" "People" ] [
                    F.Table.header [] [
                        F.Table.row [] [
                            F.Table.headerCell [] [ Html.text "Name" ]
                            F.Table.headerCell [] [ Html.text "Role" ]
                        ]
                    ]
                    F.Table.body [] [
                        F.Table.row [] [
                            F.Table.cell [] [ F.Table.cellLayout [] [ Html.text "Ada Lovelace" ] ]
                            F.Table.cell [] [ Html.text "Engineer" ]
                        ]
                        F.Table.row [] [
                            F.Table.cell [] [ F.Table.cellLayout [] [ Html.text "Grace Hopper" ] ]
                            F.Table.cell [] [ Html.text "Rear Admiral" ]
                        ]
                    ]
                ]
            ]
            stack [
                F.tree [ prop "aria-label" "Tree" ] [
                    F.Tree.item [ prop "itemType" "branch" ] [
                        F.Tree.itemLayout [] [ Html.text "src" ]
                    ]
                    F.Tree.item [ prop "itemType" "leaf" ] [
                        F.Tree.itemLayout [] [ Html.text "index.ts" ]
                    ]
                    F.Tree.item [ prop "itemType" "leaf" ] [
                        F.Tree.itemPersonaLayout [] [ Html.text "component.tsx" ]
                    ]
                ]
                F.flatTree [ prop "aria-label" "FlatTree" ] [
                    F.FlatTree.item [
                        prop "value" "1"
                        prop "itemType" "leaf"
                        prop "aria-level" 1
                        prop "aria-setsize" 2
                        prop "aria-posinset" 1
                    ] [ F.Tree.itemLayout [] [ Html.text "First flat item" ] ]
                    F.FlatTree.item [
                        prop "value" "2"
                        prop "itemType" "leaf"
                        prop "aria-level" 1
                        prop "aria-setsize" 2
                        prop "aria-posinset" 2
                    ] [ F.Tree.itemLayout [] [ Html.text "Second flat item" ] ]
                ]
            ]
        ]

    let private Toasts () =
        let controller = F.Toast.useToastController "websharper-demo"
        let dispatch (_: WebSharper.React.SyntheticEvent) =
            let content =
                F.toast [ prop "appearance" "primary" ] [
                    F.Toast.title [] [ Html.text "Saved" ]
                    F.Toast.body [] [ Html.text "Your changes were saved." ]
                ]
            let c = As<WebSharper.React.FluentUI.Types.ToastController> controller
            c.dispatchToast(content, JS.Undefined)
        section "Toasts" [
            F.button [ prop "appearance" "primary"; Html.on.click dispatch ] [ Html.text "Show a toast" ]
            F.Toast.toaster [ prop "toasterId" "websharper-demo" ]
        ]

    // ------------------------------------------------------------------
    // The React tree
    // ------------------------------------------------------------------

    let App () =
        let dark, setDark = React.UseState(theme.Value = "dark")
        React.UseEffect((fun () -> setFluentDark <- Some (fun d -> setDark.Invoke d)), [||]) |> ignore

        let fluentTheme =
            if dark then Themes.teamsDarkTheme else Themes.teamsLightTheme

        F.fluentProvider [ prop "theme" fluentTheme ] [
            Html.div [ Html.attr.className "showcase" ] [
                guard "Buttons" (Buttons ())
                guard "Badges" (Badges ())
                guard "Cards" (Cards ())
                guard "Inputs" (Inputs ())
                guard "Navigation" (Navigation ())
                guard "Surfaces" (Surfaces ())
                guard "Status" (Status ())
                guard "Data" (Data ())
                guard "Toasts" (Toasts ())
            ]
        ]

    // ------------------------------------------------------------------
    // Entry point
    // ------------------------------------------------------------------

    [<SPAEntryPoint>]
    let Main () =
        // Restore a previously chosen theme (light is the default).
        let saved = try JS.Window.LocalStorage.GetItem themeKey with _ -> null
        if not (isNull saved) && (saved = "dark" || saved = "light") then
            theme.Value <- saved
        applyTheme ()

        try
            reactVersion.Value <- React.Version
        with _ -> ()

        // Bind the page chrome first; `.Bind()` hydrates the whole document body.
        IndexTemplate()
            .themeLabel(themeLabel.V)
            .fluentVersion(fluentVersion)
            .reactVersion(reactVersion.V)
            .status(status.V)
            .ToggleTheme(fun _ -> toggleTheme ())
            .Bind()

        // The DOM is ready now, so mount the React tree into its container.
        match JS.Document.GetElementById "fluent-root" with
        | null ->
            status.Value <- "The #fluent-root container was not found."
        | root ->
            try
                ReactHelpers.Mount root (WebSharper.React.Helpers.Helpers.ofFunction App () [])
                status.Value <- "Mounted " + fluentVersion + " through React " + React.Version
            with ex ->
                status.Value <- "Could not mount the Fluent UI tree: " + ex.Message
