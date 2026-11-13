namespace WebSharper.FluentUI.React
open WebSharper.JavaScript
open WebSharper
open Styling
[<AutoOpen; JavaScript; Sealed>]
module internal Constants =
    let [<Literal>] fluentUi = "@fluentui"
    let [<Literal>] fluentComponents = fluentUi+"/react-components"
    let [<Literal>] fluentIcons = fluentUi+"/react-icons"

[<JavaScript>]
module Themes =
    let teamsLightTheme = JS.Import<obj>("teamsLightTheme", fluentComponents)
    let teamsDarkTheme = JS.Import<obj>("teamsDarkTheme", fluentComponents)
    let tokens = JS.Import<Tokens>("tokens",fluentComponents)
[<JavaScript>]
module Components =
    let [<Inline>] Accordion<'a> = JS.Import<'a>("Accordion",fluentComponents)

    
    let [<Inline>] AccordionItem<'a> = JS.Import<'a>("AccordionItem", fluentComponents)
    let [<Inline>] AccordionHeader<'a> = JS.Import<'a>("AccordionHeader",fluentComponents)
    let [<Inline>] AccordionPanel<'a> = JS.Import<'a>("AccordionPanel", fluentComponents)
    
    let [<Inline>] Avatar<'a> = JS.Import<'a>( "Avatar",fluentComponents)
    let [<Inline>] AvatarGroup<'a> = JS.Import<'a>( "AvatarGroup",fluentComponents)

    let [<Inline>] Badge<'a> = JS.Import<'a>("Badge",fluentComponents)
    let [<Inline>] CounterBadge<'a> = JS.Import<'a>( "CounterBadge",fluentComponents)
    let [<Inline>] PresenceBadge<'a> = JS.Import<'a>( "PresenceBadge",fluentComponents)

    let [<Inline>] Breadcrumb<'a> = JS.Import<'a>("Breadcrumb",fluentComponents)
    let [<Inline>] BreadcrumbItem<'a> = JS.Import<'a>("BreadcrumbItem",fluentComponents)
    let [<Inline>] BreadcrumbButton<'a> = JS.Import<'a>("BreadcrumbButton",fluentComponents)
    let [<Inline>] BreadcrumbDivider<'a> = JS.Import<'a>("BreadcrumbDivider",fluentComponents)
    
    let [<Inline>] Button<'a> = JS.Import<'a>("Button",fluentComponents)
    let [<Inline>] CompoundButton<'a> = JS.Import<'a>("CompoundButton",fluentComponents)
    let [<Inline>] MenuButton<'a> = JS.Import<'a>("MenuButton",fluentComponents)
    let [<Inline>] SplitButton<'a> = JS.Import<'a>("SplitButton",fluentComponents)
    let [<Inline>] ToggleButton<'a> = JS.Import<'a>("ToggleButton",fluentComponents)

    let [<Inline>] Card<'a> = JS.Import<'a>("Card",fluentComponents)
    let [<Inline>] CardHeader<'a> = JS.Import<'a>("CardHeader",fluentComponents)
    let [<Inline>] CardFooter<'a> = JS.Import<'a>("CardFooter",fluentComponents)
    let [<Inline>] CardPreview<'a> = JS.Import<'a>("CardPreview",fluentComponents)
    
    

    let [<Inline>] Checkbox<'a> = JS.Import<'a>("Checkbox", fluentComponents)
    let [<Inline>] Combobox<'a> = JS.Import<'a>("Combobox", fluentComponents)
    
    let [<Inline>] Option<'a> = JS.Import<'a>("Option", fluentComponents)
    let [<Inline>] Listbox<'a> = JS.Import<'a>("Listbox", fluentComponents)

    let [<Inline>] DataGrid<'a> = JS.Import<'a>("DataGrid", fluentComponents)
    let [<Inline>] DataGridHeader<'a> = JS.Import<'a>("DataGridHeader", fluentComponents)
    let [<Inline>] DataGridHeaderCell<'a> = JS.Import<'a>("DataGridHeaderCell", fluentComponents)
    let [<Inline>] DataGridBody<'a> = JS.Import<'a>("DataGridBody", fluentComponents)
    let [<Inline>] DataGridRow<'a> = JS.Import<'a>("DataGridRow", fluentComponents)
    let [<Inline>] DataGridCell<'a> = JS.Import<'a>("DataGridCell", fluentComponents)
    let [<Inline>] DataGridSelectionCell<'a> = JS.Import<'a>("DataGridSelectionCell", fluentComponents)

    let [<Inline>] Dialog<'a> = JS.Import<'a>("Dialog", fluentComponents)
    let [<Inline>] DialogBody<'a> = JS.Import<'a>("DialogBody", fluentComponents)
    let [<Inline>] DialogContent<'a> = JS.Import<'a>("DialogContent", fluentComponents)

    let [<Inline>] DialogTrigger<'a> = JS.Import<'a>("DialogTrigger", fluentComponents)
    let [<Inline>] DialogSurface<'a> = JS.Import<'a>("DialogSurface", fluentComponents)
    let [<Inline>] DialogTitle<'a> = JS.Import<'a>("DialogTitle", fluentComponents)
    let [<Inline>] DialogActions<'a> = JS.Import<'a>("DialogActions", fluentComponents)

    let [<Inline>] Drawer<'a> = JS.Import<'a>("Drawer", fluentComponents)
    let [<Inline>] InlineDrawer<'a> = JS.Import<'a>("InlineDrawer", fluentComponents)
    let [<Inline>] OverlayDrawer<'a> = JS.Import<'a>("OverlayDrawer", fluentComponents)
    let [<Inline>] DrawerHeader<'a> = JS.Import<'a>("DrawerHeader", fluentComponents)
    let [<Inline>] DrawerHeaderTitle<'a> = JS.Import<'a>("DrawerHeaderTitle", fluentComponents)
    let [<Inline>] DrawerHeaderNavigation<'a> = JS.Import<'a>("DrawerHeaderNavigation", fluentComponents)
    let [<Inline>] DrawerBody<'a> = JS.Import<'a>("DrawerBody", fluentComponents)
    
    let [<Inline>] Divider<'a> = JS.Import<'a>("Divider", fluentComponents)
    let [<Inline>] Dropdown<'a> = JS.Import<'a>("Dropdown", fluentComponents)
    
    let [<Inline>] FluentProvider<'a> = JS.Import<'a>("FluentProvider", fluentComponents)
    let [<Inline>] Field<'a> = JS.Import<'a>("Field", fluentComponents)
    let [<Inline>] Image<'a> = JS.Import<'a>("Image", fluentComponents)
    let [<Inline>] InfoLabel<'a> = JS.Import<'a>("InfoLabel", fluentComponents)
    let [<Inline>] Input<'a> = JS.Import<'a>("Input", fluentComponents)
    let [<Inline>] Label<'a> = JS.Import<'a>("Label", fluentComponents)
    let [<Inline>] Link<'a> = JS.Import<'a>("Link", fluentComponents)
    let [<Inline>] Menu<'a> = JS.Import<'a>("Menu", fluentComponents)
    let [<Inline>] MenuList<'a> = JS.Import<'a>("MenuList", fluentComponents)
    let [<Inline>] MenuTrigger<'a> = JS.Import<'a>("MenuTrigger", fluentComponents)
    let [<Inline>] MenuPopover<'a> = JS.Import<'a>("MenuPopover", fluentComponents)
    let [<Inline>] MenuItem<'a> = JS.Import<'a>("MenuItem", fluentComponents)

    let [<Inline>] MessageBar<'a> = JS.Import<'a>("MessageBar", fluentComponents)
    let [<Inline>] MessageBarGroup<'a> = JS.Import<'a>("MessageBarGroup", fluentComponents)
    let [<Inline>] MessageBarBody<'a> = JS.Import<'a>("MessageBarBody", fluentComponents)
    let [<Inline>] MessageBarTitle<'a> = JS.Import<'a>("MessageBarTitle", fluentComponents)
    let [<Inline>] MessageBarActions<'a> = JS.Import<'a>("MessageBarActions", fluentComponents)
    
    let [<Inline>] Overflow<'a> = JS.Import<'a>("Overflow", fluentComponents)
    let [<Inline>] OverflowItem<'a> = JS.Import<'a>("OverflowItem", fluentComponents)
    let [<Inline>] Persona<'a> = JS.Import<'a>("Persona", fluentComponents)

    let [<Inline>] Popover<'a> = JS.Import<'a>("Popover",fluentComponents)
    // module [<AutoOpen>] Popover =
    let [<Inline>] PopoverTrigger<'a> = JS.Import<'a>("PopoverTrigger",fluentComponents)
    let [<Inline>] PopoverSurface<'a> = JS.Import<'a>("PopoverSurface",fluentComponents)
    let [<Inline>] PopoverProvider<'a> = JS.Import<'a>("PopoverProvider",fluentComponents)
    let [<Inline>] Portal<'a> = JS.Import<'a>("Portal",fluentComponents)
    let [<Inline>] ProgressBar<'a> = JS.Import<'a>("ProgressBar", fluentComponents)

    let [<Inline>] Radio<'a> = JS.Import<'a>("Radio", fluentComponents)
    let [<Inline>] RadioGroup<'a> = JS.Import<'a>("RadioGroup", fluentComponents)
    let [<Inline>] Select<'a> = JS.Import<'a>("Select", fluentComponents)
    let [<Inline>] Skeleton<'a> = JS.Import<'a>("Skeleton", fluentComponents)
    // module [<AutoOpen>] Skeleton =
    let [<Inline>] SkeletonItem<'a> = JS.Import<'a>("SkeletonItem", fluentComponents)
    let [<Inline>] Slider<'a> = JS.Import<'a>("Slider", fluentComponents)
    let [<Inline>] SpinButton<'a> = JS.Import<'a>("SpinButton", fluentComponents)
    let [<Inline>] Spinner<'a> = JS.Import<'a>("Spinner", fluentComponents)
    let [<Inline>] Switch<'a> = JS.Import<'a>("Switch", fluentComponents)
    let [<Inline>] Table<'a> = JS.Import<'a>("Table", fluentComponents)
    // module [<AutoOpen>] Table =
    let [<Inline>] TableHeader<'a> = JS.Import<'a>("TableHeader", fluentComponents)
    let [<Inline>] TableHeaderCell<'a> = JS.Import<'a>("TableHeaderCell", fluentComponents)
    let [<Inline>] TableBody<'a> = JS.Import<'a>("TableBody", fluentComponents)
    let [<Inline>] TableRow<'a> = JS.Import<'a>("TableRow", fluentComponents)
    let [<Inline>] TableCell<'a> = JS.Import<'a>("TableCell", fluentComponents)
    let [<Inline>] TableSelectionCell<'a> = JS.Import<'a>("TableSelectionCell", fluentComponents)
    let [<Inline>] TableCellLayout<'a> = JS.Import<'a>("TableCellLayout", fluentComponents)

    let [<Inline>] TabList<'a> = JS.Import<'a>("TabList", fluentComponents)
    let [<Inline>] Tab<'a> = JS.Import<'a>("Tab", fluentComponents)

    let [<Inline>] Tag<'a> = JS.Import<'a>("Tag", fluentComponents)
    let [<Inline>] TagGroup<'a> = JS.Import<'a>("TagGroup", fluentComponents)
    
    let [<Inline>] InteractionTag<'a> = JS.Import<'a>("InteractionTag", fluentComponents)
    // module [<AutoOpen>] InteractionTag =
    let [<Inline>] InteractionTagPrimary<'a> = JS.Import<'a>("InteractionTagPrimary", fluentComponents)
    let [<Inline>] InteractionTagSecondary<'a> = JS.Import<'a>("InteractionTagSecondary", fluentComponents)
    let [<Inline>] Text<'a> = JS.Import<'a>("Text", fluentComponents)
    let [<Inline>] Textarea<'a> = JS.Import<'a>("Textarea", fluentComponents)
    let [<Inline>] Toast<'a> = JS.Import<'a>("Toast", fluentComponents)
    // module [<AutoOpen>] Toast =
    let [<Inline>] useToastController toasterId = JS.Import<string -> obj>("useToastController",fluentComponents)
    let [<Inline>] ToastTitle<'a> = JS.Import<'a>("ToastTitle", fluentComponents)
    let [<Inline>] ToastBody<'a> = JS.Import<'a>("ToastBody", fluentComponents)
    let [<Inline>] ToastFooter<'a> = JS.Import<'a>("ToastFooter", fluentComponents)
    let [<Inline>] ToastToaster<'a> = JS.Import<'a>("Toaster", fluentComponents)

    let [<Inline>] Toolbar<'a> = JS.Import<'a>("Toolbar", fluentComponents)
    // module [<AutoOpen>] Toolbar =
    let [<Inline>] ToolbarButton<'a> = JS.Import<'a>("ToolbarButton", fluentComponents)
    let [<Inline>] ToolbarDivider<'a> = JS.Import<'a>("ToolbarDivider", fluentComponents)
    let [<Inline>] ToolbarGroup<'a> = JS.Import<'a>("ToolbarGroup", fluentComponents)
    let [<Inline>] ToolbarRadioButton<'a> = JS.Import<'a>("ToolbarRadioButton", fluentComponents)
    let [<Inline>] ToolbarRadioGroup<'a> = JS.Import<'a>("ToolbarRadioGroup", fluentComponents)
    let [<Inline>] ToolbarToggleButton<'a> = JS.Import<'a>("ToolbarToggleButton", fluentComponents)

    let [<Inline>] Tooltip<'a> = JS.Import<'a>("Tooltip", fluentComponents)
    let [<Inline>] Tree<'a> = JS.Import<'a>("Tree", fluentComponents)
    // module [<AutoOpen>] Tree =
    let [<Inline>] TreeItem<'a> = JS.Import<'a>("TreeItem", fluentComponents)
    let [<Inline>] TreeItemLayout<'a> = JS.Import<'a>("TreeItemLayout", fluentComponents)
    let [<Inline>] TreeItemPersonaLayout<'a> = JS.Import<'a>("TreeItemPersonaLayout", fluentComponents)
    let [<Inline>] FlatTree<'a> = JS.Import<'a>("FlatTree", fluentComponents)
    // module [<AutoOpen>] FlatTree =
    let [<Inline>] FlatTreeItem<'a> = JS.Import<'a>("FlatTreeItem", fluentComponents)

    // Navigation

    let [<Inline>] Nav<'a> = JS.Import<'a>("Nav", fluentComponents)
    let [<Inline>] NavItem<'a> = JS.Import<'a>("NavItem", fluentComponents)
    let [<Inline>] NavCategory<'a> = JS.Import<'a>("NavCategory", fluentComponents)
    let [<Inline>] NavCategoryItem<'a> = JS.Import<'a>("NavCategoryItem", fluentComponents)
    let [<Inline>] NavSubItem<'a> = JS.Import<'a>("NavSubItem", fluentComponents)
    let [<Inline>] NavSubItemGroup<'a> = JS.Import<'a>("NavSubItemGroup", fluentComponents)
    let [<Inline>] NavDivider<'a> = JS.Import<'a>("NavDivider", fluentComponents)
    let [<Inline>] NavSectionHeader<'a> = JS.Import<'a>("NavSectionHeader", fluentComponents)
    let [<Inline>] NavDrawer<'a> = JS.Import<'a>("NavDrawer", fluentComponents)
    let [<Inline>] NavDrawerBody<'a> = JS.Import<'a>("NavDrawerBody", fluentComponents)
    let [<Inline>] NavDrawerHeader<'a> = JS.Import<'a>("NavDrawerHeader", fluentComponents)
    let [<Inline>] NavDrawerFooter<'a> = JS.Import<'a>("NavDrawerFooter", fluentComponents)
    let [<Inline>] SplitNavItem<'a> = JS.Import<'a>("SplitNavItem", fluentComponents)
    let [<Inline>] Hamburger<'a> = JS.Import<'a>("Hamburger", fluentComponents)
    let [<Inline>] AppItem<'a> = JS.Import<'a>("AppItem", fluentComponents)
    let [<Inline>] AppItemStatic<'a> = JS.Import<'a>("AppItemStatic", fluentComponents)

    // Remaining components

    // Typography presets
    let [<Inline>] Body1<'a> = JS.Import<'a>("Body1", fluentComponents)
    let [<Inline>] Body1Strong<'a> = JS.Import<'a>("Body1Strong", fluentComponents)
    let [<Inline>] Body1Stronger<'a> = JS.Import<'a>("Body1Stronger", fluentComponents)
    let [<Inline>] Body2<'a> = JS.Import<'a>("Body2", fluentComponents)
    let [<Inline>] Caption1<'a> = JS.Import<'a>("Caption1", fluentComponents)
    let [<Inline>] Caption1Strong<'a> = JS.Import<'a>("Caption1Strong", fluentComponents)
    let [<Inline>] Caption1Stronger<'a> = JS.Import<'a>("Caption1Stronger", fluentComponents)
    let [<Inline>] Caption2<'a> = JS.Import<'a>("Caption2", fluentComponents)
    let [<Inline>] Caption2Strong<'a> = JS.Import<'a>("Caption2Strong", fluentComponents)
    let [<Inline>] Display<'a> = JS.Import<'a>("Display", fluentComponents)
    let [<Inline>] LargeTitle<'a> = JS.Import<'a>("LargeTitle", fluentComponents)
    let [<Inline>] Subtitle1<'a> = JS.Import<'a>("Subtitle1", fluentComponents)
    let [<Inline>] Subtitle2<'a> = JS.Import<'a>("Subtitle2", fluentComponents)
    let [<Inline>] Subtitle2Stronger<'a> = JS.Import<'a>("Subtitle2Stronger", fluentComponents)
    let [<Inline>] Title1<'a> = JS.Import<'a>("Title1", fluentComponents)
    let [<Inline>] Title2<'a> = JS.Import<'a>("Title2", fluentComponents)
    let [<Inline>] Title3<'a> = JS.Import<'a>("Title3", fluentComponents)

    // List
    let [<Inline>] List<'a> = JS.Import<'a>("List", fluentComponents)
    let [<Inline>] ListItem<'a> = JS.Import<'a>("ListItem", fluentComponents)

    // Menu
    let [<Inline>] MenuDivider<'a> = JS.Import<'a>("MenuDivider", fluentComponents)
    let [<Inline>] MenuGroup<'a> = JS.Import<'a>("MenuGroup", fluentComponents)
    let [<Inline>] MenuGroupHeader<'a> = JS.Import<'a>("MenuGroupHeader", fluentComponents)
    let [<Inline>] MenuItemCheckbox<'a> = JS.Import<'a>("MenuItemCheckbox", fluentComponents)
    let [<Inline>] MenuItemLink<'a> = JS.Import<'a>("MenuItemLink", fluentComponents)
    let [<Inline>] MenuItemRadio<'a> = JS.Import<'a>("MenuItemRadio", fluentComponents)
    let [<Inline>] MenuItemSwitch<'a> = JS.Import<'a>("MenuItemSwitch", fluentComponents)
    let [<Inline>] MenuSplitGroup<'a> = JS.Import<'a>("MenuSplitGroup", fluentComponents)

    // Overflow
    let [<Inline>] OverflowDivider<'a> = JS.Import<'a>("OverflowDivider", fluentComponents)
    let [<Inline>] OverflowReorderObserver<'a> = JS.Import<'a>("OverflowReorderObserver", fluentComponents)

    // Avatar
    let [<Inline>] AvatarGroupItem<'a> = JS.Import<'a>("AvatarGroupItem", fluentComponents)
    let [<Inline>] AvatarGroupPopover<'a> = JS.Import<'a>("AvatarGroupPopover", fluentComponents)
    let [<Inline>] PresenceGroup<'a> = JS.Import<'a>("PresenceGroup", fluentComponents)

    // Carousel
    let [<Inline>] Carousel<'a> = JS.Import<'a>("Carousel", fluentComponents)
    let [<Inline>] CarouselAutoplayButton<'a> = JS.Import<'a>("CarouselAutoplayButton", fluentComponents)
    let [<Inline>] CarouselButton<'a> = JS.Import<'a>("CarouselButton", fluentComponents)
    let [<Inline>] CarouselCard<'a> = JS.Import<'a>("CarouselCard", fluentComponents)
    let [<Inline>] CarouselNav<'a> = JS.Import<'a>("CarouselNav", fluentComponents)
    let [<Inline>] CarouselNavButton<'a> = JS.Import<'a>("CarouselNavButton", fluentComponents)
    let [<Inline>] CarouselNavContainer<'a> = JS.Import<'a>("CarouselNavContainer", fluentComponents)
    let [<Inline>] CarouselNavImageButton<'a> = JS.Import<'a>("CarouselNavImageButton", fluentComponents)
    let [<Inline>] CarouselSlider<'a> = JS.Import<'a>("CarouselSlider", fluentComponents)
    let [<Inline>] CarouselViewport<'a> = JS.Import<'a>("CarouselViewport", fluentComponents)

    // Color picker and swatches
    let [<Inline>] ColorArea<'a> = JS.Import<'a>("ColorArea", fluentComponents)
    let [<Inline>] ColorPicker<'a> = JS.Import<'a>("ColorPicker", fluentComponents)
    let [<Inline>] ColorSlider<'a> = JS.Import<'a>("ColorSlider", fluentComponents)
    let [<Inline>] ColorSwatch<'a> = JS.Import<'a>("ColorSwatch", fluentComponents)
    let [<Inline>] AlphaSlider<'a> = JS.Import<'a>("AlphaSlider", fluentComponents)
    let [<Inline>] EmptySwatch<'a> = JS.Import<'a>("EmptySwatch", fluentComponents)
    let [<Inline>] ImageSwatch<'a> = JS.Import<'a>("ImageSwatch", fluentComponents)
    let [<Inline>] SwatchPicker<'a> = JS.Import<'a>("SwatchPicker", fluentComponents)
    let [<Inline>] SwatchPickerRow<'a> = JS.Import<'a>("SwatchPickerRow", fluentComponents)

    // Rating
    let [<Inline>] Rating<'a> = JS.Import<'a>("Rating", fluentComponents)
    let [<Inline>] RatingDisplay<'a> = JS.Import<'a>("RatingDisplay", fluentComponents)
    let [<Inline>] RatingItem<'a> = JS.Import<'a>("RatingItem", fluentComponents)

    // Search and tags
    let [<Inline>] SearchBox<'a> = JS.Import<'a>("SearchBox", fluentComponents)
    let [<Inline>] TagPicker<'a> = JS.Import<'a>("TagPicker", fluentComponents)
    let [<Inline>] TagPickerButton<'a> = JS.Import<'a>("TagPickerButton", fluentComponents)
    let [<Inline>] TagPickerControl<'a> = JS.Import<'a>("TagPickerControl", fluentComponents)
    let [<Inline>] TagPickerGroup<'a> = JS.Import<'a>("TagPickerGroup", fluentComponents)
    let [<Inline>] TagPickerInput<'a> = JS.Import<'a>("TagPickerInput", fluentComponents)
    let [<Inline>] TagPickerList<'a> = JS.Import<'a>("TagPickerList", fluentComponents)
    let [<Inline>] TagPickerOption<'a> = JS.Import<'a>("TagPickerOption", fluentComponents)
    let [<Inline>] TagPickerOptionGroup<'a> = JS.Import<'a>("TagPickerOptionGroup", fluentComponents)
    let [<Inline>] OptionGroup<'a> = JS.Import<'a>("OptionGroup", fluentComponents)

    // Table extras
    let [<Inline>] TableCellActions<'a> = JS.Import<'a>("TableCellActions", fluentComponents)
    let [<Inline>] TableResizeHandle<'a> = JS.Import<'a>("TableResizeHandle", fluentComponents)

    // Teaching popover
    let [<Inline>] TeachingPopover<'a> = JS.Import<'a>("TeachingPopover", fluentComponents)
    let [<Inline>] TeachingPopoverBody<'a> = JS.Import<'a>("TeachingPopoverBody", fluentComponents)
    let [<Inline>] TeachingPopoverCarousel<'a> = JS.Import<'a>("TeachingPopoverCarousel", fluentComponents)
    let [<Inline>] TeachingPopoverCarouselCard<'a> = JS.Import<'a>("TeachingPopoverCarouselCard", fluentComponents)
    let [<Inline>] TeachingPopoverCarouselFooter<'a> = JS.Import<'a>("TeachingPopoverCarouselFooter", fluentComponents)
    let [<Inline>] TeachingPopoverCarouselNav<'a> = JS.Import<'a>("TeachingPopoverCarouselNav", fluentComponents)
    let [<Inline>] TeachingPopoverCarouselNavButton<'a> = JS.Import<'a>("TeachingPopoverCarouselNavButton", fluentComponents)
    let [<Inline>] TeachingPopoverCarouselPageCount<'a> = JS.Import<'a>("TeachingPopoverCarouselPageCount", fluentComponents)
    let [<Inline>] TeachingPopoverFooter<'a> = JS.Import<'a>("TeachingPopoverFooter", fluentComponents)
    let [<Inline>] TeachingPopoverHeader<'a> = JS.Import<'a>("TeachingPopoverHeader", fluentComponents)
    let [<Inline>] TeachingPopoverSurface<'a> = JS.Import<'a>("TeachingPopoverSurface", fluentComponents)
    let [<Inline>] TeachingPopoverTitle<'a> = JS.Import<'a>("TeachingPopoverTitle", fluentComponents)
    let [<Inline>] TeachingPopoverTrigger<'a> = JS.Import<'a>("TeachingPopoverTrigger", fluentComponents)

    // Miscellaneous
    let [<Inline>] AriaLiveAnnouncer<'a> = JS.Import<'a>("AriaLiveAnnouncer", fluentComponents)
    let [<Inline>] DrawerFooter<'a> = JS.Import<'a>("DrawerFooter", fluentComponents)
    let [<Inline>] InfoButton<'a> = JS.Import<'a>("InfoButton", fluentComponents)
    let [<Inline>] ToastTrigger<'a> = JS.Import<'a>("ToastTrigger", fluentComponents)
    let [<Inline>] TreeRootReset<'a> = JS.Import<'a>("TreeRootReset", fluentComponents)

    // Context providers (advanced usage)
    let [<Inline>] AccordionItemProvider<'a> = JS.Import<'a>("AccordionItemProvider", fluentComponents)
    let [<Inline>] AccordionProvider<'a> = JS.Import<'a>("AccordionProvider", fluentComponents)
    let [<Inline>] AnnounceProvider<'a> = JS.Import<'a>("AnnounceProvider", fluentComponents)
    let [<Inline>] AvatarGroupProvider<'a> = JS.Import<'a>("AvatarGroupProvider", fluentComponents)
    let [<Inline>] BreadcrumbProvider<'a> = JS.Import<'a>("BreadcrumbProvider", fluentComponents)
    let [<Inline>] CarouselProvider<'a> = JS.Import<'a>("CarouselProvider", fluentComponents)
    let [<Inline>] ColumnIdContextProvider<'a> = JS.Import<'a>("ColumnIdContextProvider", fluentComponents)
    let [<Inline>] ComboboxProvider<'a> = JS.Import<'a>("ComboboxProvider", fluentComponents)
    let [<Inline>] DataGridContextProvider<'a> = JS.Import<'a>("DataGridContextProvider", fluentComponents)
    let [<Inline>] DialogProvider<'a> = JS.Import<'a>("DialogProvider", fluentComponents)
    let [<Inline>] DrawerProvider<'a> = JS.Import<'a>("DrawerProvider", fluentComponents)
    let [<Inline>] FieldContextProvider<'a> = JS.Import<'a>("FieldContextProvider", fluentComponents)
    let [<Inline>] IdPrefixProvider<'a> = JS.Import<'a>("IdPrefixProvider", fluentComponents)
    let [<Inline>] ListboxProvider<'a> = JS.Import<'a>("ListboxProvider", fluentComponents)
    let [<Inline>] MenuGroupContextProvider<'a> = JS.Import<'a>("MenuGroupContextProvider", fluentComponents)
    let [<Inline>] MenuListProvider<'a> = JS.Import<'a>("MenuListProvider", fluentComponents)
    let [<Inline>] MenuProvider<'a> = JS.Import<'a>("MenuProvider", fluentComponents)
    let [<Inline>] MenuTriggerContextProvider<'a> = JS.Import<'a>("MenuTriggerContextProvider", fluentComponents)
    let [<Inline>] MessageBarContextProvider<'a> = JS.Import<'a>("MessageBarContextProvider", fluentComponents)
    let [<Inline>] NavCategoryItemProvider<'a> = JS.Import<'a>("NavCategoryItemProvider", fluentComponents)
    let [<Inline>] NavCategoryProvider<'a> = JS.Import<'a>("NavCategoryProvider", fluentComponents)
    let [<Inline>] NavProvider<'a> = JS.Import<'a>("NavProvider", fluentComponents)
    let [<Inline>] PortalMountNodeProvider<'a> = JS.Import<'a>("PortalMountNodeProvider", fluentComponents)
    let [<Inline>] PositioningConfigurationProvider<'a> = JS.Import<'a>("PositioningConfigurationProvider", fluentComponents)
    let [<Inline>] RadioGroupProvider<'a> = JS.Import<'a>("RadioGroupProvider", fluentComponents)
    let [<Inline>] RatingItemProvider<'a> = JS.Import<'a>("RatingItemProvider", fluentComponents)
    let [<Inline>] RendererProvider<'a> = JS.Import<'a>("RendererProvider", fluentComponents)
    let [<Inline>] SSRProvider<'a> = JS.Import<'a>("SSRProvider", fluentComponents)
    let [<Inline>] SkeletonContextProvider<'a> = JS.Import<'a>("SkeletonContextProvider", fluentComponents)
    let [<Inline>] SwatchPickerProvider<'a> = JS.Import<'a>("SwatchPickerProvider", fluentComponents)
    let [<Inline>] TabListProvider<'a> = JS.Import<'a>("TabListProvider", fluentComponents)
    let [<Inline>] TableContextProvider<'a> = JS.Import<'a>("TableContextProvider", fluentComponents)
    let [<Inline>] TableHeaderContextProvider<'a> = JS.Import<'a>("TableHeaderContextProvider", fluentComponents)
    let [<Inline>] TableRowIdContextProvider<'a> = JS.Import<'a>("TableRowIdContextProvider", fluentComponents)
    let [<Inline>] TreeItemProvider<'a> = JS.Import<'a>("TreeItemProvider", fluentComponents)
    let [<Inline>] TreeProvider<'a> = JS.Import<'a>("TreeProvider", fluentComponents)

/// Helper functions exported by `@fluentui/react-components`. They take and
/// return plain objects, so they are imported untyped; the shapes live in
/// `WebSharper.React.FluentUI.Types`.
[<JavaScript>]
module Utilities =
    let partitionBreadcrumbItems = JS.Import<obj -> obj>("partitionBreadcrumbItems", fluentComponents)
    let partitionAvatarGroupItems = JS.Import<obj -> obj>("partitionAvatarGroupItems", fluentComponents)

    let createLightTheme = JS.Import<obj -> obj>("createLightTheme", fluentComponents)
    let createDarkTheme = JS.Import<obj -> obj>("createDarkTheme", fluentComponents)
    let createHighContrastTheme = JS.Import<obj -> obj>("createHighContrastTheme", fluentComponents)
    let createTeamsDarkTheme = JS.Import<obj -> obj>("createTeamsDarkTheme", fluentComponents)
    let themeToTokensObject = JS.Import<obj -> obj>("themeToTokensObject", fluentComponents)
