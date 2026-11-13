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

    let private Typography () =
        section "Typography" [
            stack [
                F.display [] [ Html.text "Display" ]
                F.largeTitle [] [ Html.text "Large title" ]
                F.title1 [] [ Html.text "Title 1" ]
                F.title2 [] [ Html.text "Title 2" ]
                F.title3 [] [ Html.text "Title 3" ]
                F.subtitle1 [] [ Html.text "Subtitle 1" ]
                F.subtitle2 [] [ Html.text "Subtitle 2" ]
                F.subtitle2Stronger [] [ Html.text "Subtitle 2 stronger" ]
            ]
            stack [
                F.body1 [] [ Html.text "Body 1 — the default body text." ]
                F.body1Strong [] [ Html.text "Body 1 strong" ]
                F.body1Stronger [] [ Html.text "Body 1 stronger" ]
                F.body2 [] [ Html.text "Body 2" ]
                F.caption1 [] [ Html.text "Caption 1" ]
                F.caption1Strong [] [ Html.text "Caption 1 strong" ]
                F.caption1Stronger [] [ Html.text "Caption 1 stronger" ]
                F.caption2 [] [ Html.text "Caption 2" ]
                F.caption2Strong [] [ Html.text "Caption 2 strong" ]
                F.text [ prop "size" 400; prop "weight" "semibold" ] [ Html.text "Text (size 400, semibold)" ]
                F.infoButton [ prop "info" "InfoButton opens a tooltip." ] []
            ]
        ]

    let private Lists () =
        section "Lists" [
            stack [
                F.list [ prop "aria-label" "A simple list" ] [
                    F.listItem [] [ Html.text "The first item" ]
                    F.listItem [] [ Html.text "The second item" ]
                    F.listItem [] [ Html.text "The third item" ]
                ]
            ]
            stack [
                F.list [ prop "aria-label" "A selectable list"; prop "selectionMode" "multiselect" ] [
                    F.listItem [ prop "value" "a" ] [ Html.text "Selectable A" ]
                    F.listItem [ prop "value" "b" ] [ Html.text "Selectable B" ]
                    F.listItem [ prop "value" "c" ] [ Html.text "Selectable C" ]
                ]
            ]
        ]

    let private Menus () =
        section "Menus" [
            F.menu [] [
                F.Menu.trigger [ prop "disableButtonEnhancement" true ] [
                    F.button [] [ Html.text "Grouped menu" ]
                ]
                F.Menu.popover [] [
                    F.menuList [] [
                        F.menuGroup [] [
                            F.menuGroupHeader [] [ Html.text "Edit" ]
                            F.Menu.item [] [ Html.text "Undo" ]
                            F.Menu.item [] [ Html.text "Redo" ]
                        ]
                        F.menuDivider [] []
                        F.menuItemCheckbox [ prop "name" "wrap"; prop "value" "wrap" ] [ Html.text "Word wrap" ]
                        F.menuItemRadio [ prop "name" "align"; prop "value" "left" ] [ Html.text "Align left" ]
                        F.menuItemRadio [ prop "name" "align"; prop "value" "right" ] [ Html.text "Align right" ]
                        F.menuItemSwitch [ prop "name" "preview"; prop "value" "preview" ] [ Html.text "Live preview" ]
                        F.menuDivider [] []
                        F.menuItemLink [ prop "href" "https://react.fluentui.dev/" ] [ Html.text "Fluent UI docs" ]
                        F.menuSplitGroup [] [
                            F.Menu.item [] [ Html.text "Split item" ]
                            F.Menu.item [] [ Html.text "More" ]
                        ]
                    ]
                ]
            ]
            F.menuButton [ prop "disableButtonEnhancement" true ] [ Html.text "Menu button" ]
            F.splitButton [ prop "disableButtonEnhancement" true ] [ Html.text "Split button" ]
        ]

    let private Avatars () =
        section "Avatars and presence" [
            F.avatarGroup [ prop "layout" "stack" ] [
                F.avatarGroupItem [ prop "name" "Ada Lovelace" ] []
                F.avatarGroupItem [ prop "name" "Grace Hopper" ] []
                F.avatarGroupPopover [ prop "count" 3 ] [
                    F.avatarGroupItem [ prop "name" "Alan Turing" ] []
                    F.avatarGroupItem [ prop "name" "Katherine Johnson" ] []
                ]
            ]
            F.presenceGroup [] [
                F.presenceBadge [ prop "status" "available" ]
                F.presenceBadge [ prop "status" "busy" ]
                F.presenceBadge [ prop "status" "away" ]
            ]
        ]

    let private RatingAndSearch () =
        section "Rating and search" [
            stack [
                F.rating [ prop "defaultValue" 3; prop "max" 5 ] []
                F.ratingDisplay [ prop "value" 4.5; prop "count" 128; prop "color" "marigold" ] []
            ]
            stack [
                F.searchBox [ prop "placeholder" "Search components"; prop "defaultValue" "Fluent" ] []
            ]
        ]

    let private TagPickers () =
        section "Tag picker" [
            stack [
                F.tagPicker [] [
                    F.tagPickerControl [] [
                        F.tagPickerGroup [] [
                            F.tag [ prop "dismissible" true ] [ Html.text "F#" ]
                        ]
                        F.tagPickerInput [
                            prop "aria-label" "Tags"
                            prop "placeholder" "Add a tag"
                        ] []
                    ]
                    F.tagPickerList [] [
                        F.tagPickerOption [ prop "value" "react" ] [ Html.text "React" ]
                        F.tagPickerOption [ prop "value" "websharper" ] [ Html.text "WebSharper" ]
                    ]
                ]
            ]
            stack [
                F.combobox [ prop "placeholder" "Grouped options" ] [
                    F.optionGroup [ prop "label" "Languages" ] [
                        F.option [ prop "value" "fsharp" ] [ Html.text "F#" ]
                        F.option [ prop "value" "csharp" ] [ Html.text "C#" ]
                    ]
                    F.optionGroup [ prop "label" "Libraries" ] [
                        F.option [ prop "value" "react" ] [ Html.text "React" ]
                    ]
                ]
            ]
        ]

    let private Colors () =
        let hsv = box {| h = 210.0; s = 0.85; v = 0.95; a = 1.0 |}
        section "Color picker and swatches" [
            stack [
                F.swatchPicker [ prop "defaultSelectedValue" "#0078d4"; prop "layout" "row" ] [
                    F.swatchPickerRow [] [
                        F.colorSwatch [ prop "color" "#0078d4"; prop "value" "#0078d4" ] []
                        F.colorSwatch [ prop "color" "#d13438"; prop "value" "#d13438" ] []
                        F.colorSwatch [ prop "color" "#107c10"; prop "value" "#107c10" ] []
                        F.emptySwatch [ prop "value" "#ffffff"; prop "aria-label" "Empty swatch" ] []
                        F.imageSwatch [ prop "src" imageDataUri; prop "value" "image"; prop "aria-label" "Image swatch" ] []
                    ]
                ]
            ]
            stack [
                F.colorPicker [ prop "color" hsv ] [
                    F.colorArea [ prop "color" hsv ] []
                    F.colorSlider [ prop "color" hsv; prop "channel" "hue" ] []
                    F.alphaSlider [ prop "color" hsv ] []
                    F.colorSwatch [ prop "color" "#0078d4"; prop "value" "preview" ] []
                ]
            ]
        ]

    let private Carousels () =
        section "Carousel" [
            F.carousel [ prop "circular" true; prop "groupSize" 1 ] [
                F.carouselViewport [] [
                    F.carouselSlider [] [
                        F.carouselCard [ prop "autoSize" true ] [
                            Html.div [ Html.attr.className "carousel-card" ] [ Html.text "Slide one" ]
                        ]
                        F.carouselCard [ prop "autoSize" true ] [
                            Html.div [ Html.attr.className "carousel-card" ] [ Html.text "Slide two" ]
                        ]
                        F.carouselCard [ prop "autoSize" true ] [
                            Html.div [ Html.attr.className "carousel-card" ] [ Html.text "Slide three" ]
                        ]
                    ]
                ]
                F.carouselNavContainer [ prop "layout" "inline" ] [
                    F.carouselButton [ prop "navType" "prev" ] []
                    F.carouselButton [ prop "navType" "next" ] []
                ]
            ]
        ]

    let private TeachingPopovers () =
        section "Teaching popover" [
            F.teachingPopover [] [
                F.teachingPopoverTrigger [ prop "disableButtonEnhancement" true ] [
                    F.button [] [ Html.text "Open teaching popover" ]
                ]
                F.teachingPopoverSurface [] [
                    F.teachingPopoverHeader [] [
                        F.teachingPopoverTitle [] [ Html.text "A guided step" ]
                    ]
                    F.teachingPopoverBody [] [
                        Html.text "Teaching popovers walk users through a new feature."
                    ]
                    F.teachingPopoverFooter [ prop "initialStepText" "Start"; prop "finalStepText" "Done" ] []
                ]
            ]
        ]

    type private GridRow = { name: string; role: string }

    type private GridColumn = {
        renderHeaderCell: unit -> React.Element
        renderCell: GridRow -> React.Element
    }

    type private GridRowData = { item: GridRow; rowId: string }

    let private DataGrids () =
        let rows =
            [| { name = "Ada Lovelace"; role = "Engineer" }
               { name = "Grace Hopper"; role = "Rear Admiral" }
               { name = "Katherine Johnson"; role = "Mathematician" } |]
        let columns : obj[] =
            [| box {| columnId = "name"
                      compare = System.Func<GridRow, GridRow, int>(fun a b -> compare a.name b.name)
                      renderHeaderCell = (fun () -> Html.text "Name")
                      renderCell = (fun (r: GridRow) -> Html.text r.name) |}
               box {| columnId = "role"
                      compare = System.Func<GridRow, GridRow, int>(fun a b -> compare a.role b.role)
                      renderHeaderCell = (fun () -> Html.text "Role")
                      renderCell = (fun (r: GridRow) -> Html.text r.role) |} |]
        // The DataGrid API is render-prop based: a row's children receive the
        // column definition, and the body's children receive the row data.
        let headerCell (column: GridColumn) =
            F.DataGrid.headerCell [] [ column.renderHeaderCell () ]
        let bodyRow (row: GridRowData) =
            F.DataGrid.row [
                prop "children" (fun (column: GridColumn) ->
                    F.DataGrid.cell [] [ column.renderCell row.item ])
            ] []
        section "Data grid" [
            F.dataGrid [
                prop "items" rows
                prop "columns" columns
                prop "getRowId" (fun (r: GridRow) -> r.name)
                prop "focusMode" "composite"
            ] [
                F.DataGrid.header [] [
                    F.DataGrid.row [ prop "children" headerCell ] []
                ]
                F.DataGrid.body [ prop "children" bodyRow ] []
            ]
        ]

    let private Misc () =
        section "Miscellaneous" [
            F.ariaLiveAnnouncer [] []
            F.table [ prop "aria-label" "A table with actions" ] [
                F.Table.header [] [
                    F.Table.row [] [ F.Table.headerCell [] [ Html.text "Name" ] ]
                ]
                F.Table.body [] [
                    F.Table.row [] [
                        F.Table.cell [] [
                            F.Table.cellLayout [] [ Html.text "Ada Lovelace" ]
                            F.tableCellActions [] [
                                F.button [ prop "appearance" "subtle" ] [ Html.text "Edit" ]
                            ]
                        ]
                    ]
                ]
            ]
        ]

    // ------------------------------------------------------------------
    // The React tree
    // ------------------------------------------------------------------

    /// The showcase sections, in navigation order.
    let private sections : (string * string * (unit -> React.Element)) list =
        [ "buttons", "Buttons", Buttons
          "badges", "Badges, avatars and personas", Badges
          "cards", "Cards", Cards
          "inputs", "Inputs and selection", Inputs
          "typography", "Typography", Typography
          "lists", "Lists", Lists
          "menus", "Menus", Menus
          "avatars", "Avatars and presence", Avatars
          "data", "Tables and trees", Data
          "datagrid", "Data grid", DataGrids
          "carousel", "Carousel", Carousels
          "rating", "Rating and search", RatingAndSearch
          "tagpicker", "Tag picker", TagPickers
          "colors", "Color picker and swatches", Colors
          "surfaces", "Dialogs, drawers and popups", Surfaces
          "teaching", "Teaching popover", TeachingPopovers
          "status", "Message bars and tags", Status
          "toasts", "Toasts", Toasts
          "misc", "Miscellaneous", Misc
          "navigation", "Navigation", Navigation ]

    let private sectionTitle (key: string) =
        match sections |> List.tryFind (fun (k, _, _) -> k = key) with
        | Some (_, title, _) -> title
        | None -> "Overview"

    /// Instantiate a function component. Rendering the sections this way (rather
    /// than calling them) scopes their hooks to the component, so they can be
    /// mounted and unmounted freely as the selection changes.
    let private fn (render: 'P -> React.Element) (props: 'P) : React.Element =
        ReactHelpers.OfFunction render props

    let App () =
        let dark, setDark = React.UseState(theme.Value = "dark")
        React.UseEffect((fun () -> setFluentDark <- Some (fun d -> setDark.Invoke d)), [||]) |> ignore

        let selected, setSelected = React.UseState "overview"
        let navOpen, setNavOpen = React.UseState true

        let fluentTheme =
            if dark then Themes.teamsDarkTheme else Themes.teamsLightTheme

        let navItem value label =
            F.navItem [
                prop "value" value
                Html.on.click (fun _ -> setSelected.Invoke value)
            ] [ Html.text label ]

        let subNavItem value label =
            F.navSubItem [
                prop "value" value
                Html.on.click (fun _ -> setSelected.Invoke value)
            ] [ Html.text label ]

        let category value label items =
            F.navCategory [ prop "value" value ] [
                F.navCategoryItem [] [ Html.text label ]
                F.navSubItemGroup [] items
            ]

        let visibleSections =
            if selected = "overview" then sections
            else sections |> List.filter (fun (k, _, _) -> k = selected)

        F.fluentProvider [ prop "theme" fluentTheme ] [
            Html.div [ Html.attr.className "app-shell" ] [

                F.navDrawer [
                    prop "type" "inline"
                    prop "open" navOpen
                    prop "separator" true
                    prop "className" "app-nav"
                    prop "aria-label" "Showcase sections"
                    prop "defaultSelectedValue" "overview"
                    prop "defaultOpenCategories" (box [| "components"; "data"; "overlays"; "navigation" |])
                ] [
                    F.NavDrawer.header [] [
                        Html.div [ Html.attr.className "nav-brand" ] [
                            Html.text "Fluent UI Showcase"
                        ]
                    ]
                    F.NavDrawer.body [ prop "className" "app-nav-body" ] [
                        navItem "overview" "Overview"
                        F.navDivider [] []
                        category "components" "Components" [
                            subNavItem "buttons" "Buttons"
                            subNavItem "badges" "Badges, avatars and personas"
                            subNavItem "cards" "Cards"
                            subNavItem "inputs" "Inputs and selection"
                            subNavItem "typography" "Typography"
                            subNavItem "lists" "Lists"
                            subNavItem "menus" "Menus"
                            subNavItem "avatars" "Avatars and presence"
                        ]
                        category "data" "Data display" [
                            subNavItem "data" "Tables and trees"
                            subNavItem "datagrid" "Data grid"
                            subNavItem "carousel" "Carousel"
                            subNavItem "rating" "Rating and search"
                            subNavItem "tagpicker" "Tag picker"
                            subNavItem "colors" "Color picker and swatches"
                        ]
                        category "overlays" "Overlays and feedback" [
                            subNavItem "surfaces" "Dialogs, drawers and popups"
                            subNavItem "teaching" "Teaching popover"
                            subNavItem "status" "Message bars and tags"
                            subNavItem "toasts" "Toasts"
                            subNavItem "misc" "Miscellaneous"
                        ]
                        category "navigation" "Navigation" [
                            subNavItem "navigation" "Navigation"
                        ]
                        F.navDivider [] []
                        F.navSectionHeader [] [ Html.text "Resources" ]
                        F.navItem [
                            prop "value" "docs"
                            prop "href" "https://react.fluentui.dev/"
                        ] [ Html.text "Fluent UI docs" ]
                        F.navItem [
                            prop "value" "source"
                            prop "href" "https://github.com/dotnet-websharper/fluentui-react-components"
                        ] [ Html.text "Source" ]
                    ]
                    F.NavDrawer.footer [] [
                        Html.div [ Html.attr.className "nav-footer" ] [
                            Html.text ("@fluentui/react-components " + fluentVersion)
                        ]
                    ]
                ]

                Html.div [ Html.attr.className "app-main" ] [
                    Html.div [ Html.attr.className "app-toolbar" ] [
                        F.hamburger [
                            prop "aria-label" "Toggle navigation"
                            Html.on.click (fun _ -> setNavOpen.Invoke (not navOpen))
                        ]
                        Html.h2 [ Html.attr.className "app-title" ] [
                            Html.text (sectionTitle selected)
                        ]
                    ]
                    Html.div [ Html.attr.className "showcase" ] [
                        for (_, title, render) in visibleSections ->
                            guard title (fn render ())
                    ]
                ]
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
