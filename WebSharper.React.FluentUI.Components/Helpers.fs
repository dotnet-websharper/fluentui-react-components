namespace WebSharper.FluentUI.React

open WebSharper
open WebSharper.React
open WebSharper.JavaScript
open Components
[<JavaScript>]
module Helpers =
        let accordion props children = ReactHelpers.Elt Accordion props children
        let accordionItem props children = ReactHelpers.Elt AccordionItem props children
        let accordionHeader props children = ReactHelpers.Elt AccordionHeader props children
        let accordionPanel props children = ReactHelpers.Elt AccordionPanel props children
        
        // avatar-related
        let avatar props = ReactHelpers.Elt Avatar props []
        let avatarGroup props children = ReactHelpers.Elt AvatarGroup props children

        // badge-related
        let badge props = ReactHelpers.Elt Badge props []
        let counterBadge props = ReactHelpers.Elt CounterBadge props []
        let presenceBadge props = ReactHelpers.Elt PresenceBadge props []
        
        let breadcrumb props children = ReactHelpers.Elt Breadcrumb props children
        module Breadcrumb =
            let item props children = ReactHelpers.Elt BreadcrumbItem props children
            let divider props children = ReactHelpers.Elt BreadcrumbDivider props children
            let button props children = ReactHelpers.Elt BreadcrumbButton props children
        // button-related
        let button props children = ReactHelpers.Elt Button props children
        let compoundButton props children = ReactHelpers.Elt CompoundButton props children
        let menuButton props children = ReactHelpers.Elt MenuButton props children
        let splitButton props children = ReactHelpers.Elt SplitButton props children
        let toggleButton props children = ReactHelpers.Elt ToggleButton props children
        
        // card-related
        let card props children = ReactHelpers.Elt Card props children
        let cardFooter props children = ReactHelpers.Elt CardFooter props children
        let cardHeader props children = ReactHelpers.Elt CardHeader props children
        let cardPreview props children = ReactHelpers.Elt CardPreview props children
        
        let checkbox props children = ReactHelpers.Elt Checkbox props children
        let combobox props children = ReactHelpers.Elt Combobox props children
        let option props children = ReactHelpers.Elt Option props children
        let listbox props children = ReactHelpers.Elt Listbox props children

        let dataGrid props children = ReactHelpers.Elt DataGrid props children
        module DataGrid =
            let header props children = ReactHelpers.Elt DataGridHeader props children
            let headerCell props children = ReactHelpers.Elt DataGridHeaderCell props children
            let body props children = ReactHelpers.Elt DataGridBody props children
            let row props children = ReactHelpers.Elt DataGridRow props children
            let cell props children = ReactHelpers.Elt DataGridCell props children
            let selectionCell props children = ReactHelpers.Elt DataGridSelectionCell props children

        let dialog props children = ReactHelpers.Elt Dialog props children
        module Dialog =
            let trigger props children = ReactHelpers.Elt DialogTrigger props children
            let surface props children = ReactHelpers.Elt DialogSurface props children
            let content props children = ReactHelpers.Elt DialogContent props children
            let body props children = ReactHelpers.Elt DialogBody props children
            let title props children = ReactHelpers.Elt DialogTitle props children
            let actions props children = ReactHelpers.Elt DialogActions props children

        let drawer props children = ReactHelpers.Elt Drawer props children
        let overlayDrawer props children = ReactHelpers.Elt OverlayDrawer props children
        let inlineDrawer props children = ReactHelpers.Elt InlineDrawer props children
        module Drawer =
            let header props children = ReactHelpers.Elt DrawerHeader props children
            let headerTitle props children = ReactHelpers.Elt DrawerHeaderTitle props children
            let headerNavigation props children = ReactHelpers.Elt DrawerHeaderNavigation props children
            let body props children = ReactHelpers.Elt DrawerBody props children
        
        let divider props children = ReactHelpers.Elt Divider props children
        let dropdown props children = ReactHelpers.Elt Dropdown props children
        let fluentProvider props children = ReactHelpers.Elt FluentProvider props children
        let field props children = ReactHelpers.Elt Field props children
        let image props = ReactHelpers.Elt Image props []
        let infoLabel props children = ReactHelpers.Elt InfoLabel props children
        let input props = ReactHelpers.Elt Input props []
        let label props children = ReactHelpers.Elt Label props children
        let link props children = ReactHelpers.Elt Link props children
        let menu props children = ReactHelpers.Elt Menu props children
        let menuList props children = ReactHelpers.Elt MenuList props children
        module Menu =
            let trigger props children = ReactHelpers.Elt MenuTrigger props children
            let popover props children = ReactHelpers.Elt MenuPopover props children
            let item props children = ReactHelpers.Elt MenuItem props children
        let messageBar props children = ReactHelpers.Elt MessageBar props children
        module MessageBar =
            let group props children = ReactHelpers.Elt MessageBarGroup props children
            let body props children = ReactHelpers.Elt MessageBarBody props children
            let title props children = ReactHelpers.Elt MessageBarTitle props children
            let actions props children = ReactHelpers.Elt MessageBarActions props children
        
        let overflow props children = ReactHelpers.Elt Overflow props children
        let overflowItem props children = ReactHelpers.Elt OverflowItem props children
        let persona props = ReactHelpers.Elt Persona props []
        let popover props children = ReactHelpers.Elt Popover props children
        module Popover =
            let popoverTrigger props children = ReactHelpers.Elt PopoverTrigger props children
            let popoverSurface props children = ReactHelpers.Elt PopoverSurface props children
            let popoverProvider props children = ReactHelpers.Elt PopoverProvider props children
        let portal props children = ReactHelpers.Elt Portal props children
        let progressBar props = ReactHelpers.Elt ProgressBar props []
        
        let radio props = ReactHelpers.Elt Radio props []
        let radioGroup props children = ReactHelpers.Elt RadioGroup props children
        let select props children = ReactHelpers.Elt Select props children
        let skeleton props children = ReactHelpers.Elt Skeleton props children
        let skeletonItem props children = ReactHelpers.Elt SkeletonItem props children
        let slider props = ReactHelpers.Elt Slider props []
        let spinButton props = ReactHelpers.Elt SpinButton props []
        let spinner props = ReactHelpers.Elt Spinner props []
        let switch props = ReactHelpers.Elt Switch props []
        let table props children = ReactHelpers.Elt Table props children
        module Table =
            let header props children = ReactHelpers.Elt TableHeader props children
            let headerCell props children = ReactHelpers.Elt TableHeaderCell props children
            let body props children = ReactHelpers.Elt TableBody props children
            let row props children = ReactHelpers.Elt TableRow props children
            let cell props children = ReactHelpers.Elt TableCell props children
            let selectionCell props children = ReactHelpers.Elt TableSelectionCell props children
            let cellLayout props children = ReactHelpers.Elt TableCellLayout props children

        let tabList props children = ReactHelpers.Elt TabList props children
        let tab props children = ReactHelpers.Elt Tab props children

        let tag props children = ReactHelpers.Elt Tag props children
        let tagGroup props children = ReactHelpers.Elt TagGroup props children
        
        let interactionTag props children = ReactHelpers.Elt InteractionTag props children
        module InteractionTag =
            let primary props children = ReactHelpers.Elt InteractionTagPrimary props children
            let secondary  props children = ReactHelpers.Elt InteractionTagSecondary props children
        let text props children = ReactHelpers.Elt Text props children
        let textarea props children = ReactHelpers.Elt Textarea props children
        let toast props children = ReactHelpers.Elt Toast props children
        module Toast =
            let useToastController toasterId = JS.Import<string -> obj>("useToastController",fluentComponents) toasterId
            let title props children = ReactHelpers.Elt ToastTitle props children
            let body props children = ReactHelpers.Elt ToastBody props children
            let footer props children = ReactHelpers.Elt ToastFooter props children
            let toaster props = ReactHelpers.Elt ToastToaster props []

        let toolbar props children = ReactHelpers.Elt Toolbar props children
        module Toolbar =
            let button props children = ReactHelpers.Elt ToolbarButton props children
            let divider props children = ReactHelpers.Elt ToolbarDivider props children
            let group props children = ReactHelpers.Elt ToolbarGroup props children
            let radioButton props children = ReactHelpers.Elt ToolbarRadioButton props children
            let radioGroup props children = ReactHelpers.Elt ToolbarRadioGroup props children
            let toggleButton props children = ReactHelpers.Elt ToolbarToggleButton props children

        let tooltip props children = ReactHelpers.Elt Tooltip props children
        let tree props children = ReactHelpers.Elt Tree props children
        module Tree =
            let item props children = ReactHelpers.Elt TreeItem props children
            let itemLayout props children = ReactHelpers.Elt TreeItemLayout props children
            let itemPersonaLayout props children = ReactHelpers.Elt TreeItemPersonaLayout props children
        let flatTree props children = ReactHelpers.Elt FlatTree props children
        module FlatTree =
            let item props children = ReactHelpers.Elt FlatTreeItem props children

        // navigation
        let nav props children = ReactHelpers.Elt Nav props children
        let navItem props children = ReactHelpers.Elt NavItem props children
        let navCategory props children = ReactHelpers.Elt NavCategory props children
        let navCategoryItem props children = ReactHelpers.Elt NavCategoryItem props children
        let navSubItem props children = ReactHelpers.Elt NavSubItem props children
        let navSubItemGroup props children = ReactHelpers.Elt NavSubItemGroup props children
        let navDivider props children = ReactHelpers.Elt NavDivider props children
        let navSectionHeader props children = ReactHelpers.Elt NavSectionHeader props children
        let navDrawer props children = ReactHelpers.Elt NavDrawer props children
        module NavDrawer =
            let body props children = ReactHelpers.Elt NavDrawerBody props children
            let header props children = ReactHelpers.Elt NavDrawerHeader props children
            let footer props children = ReactHelpers.Elt NavDrawerFooter props children
        let splitNavItem props children = ReactHelpers.Elt SplitNavItem props children
        let hamburger props = ReactHelpers.Elt Hamburger props []
        let appItem props children = ReactHelpers.Elt AppItem props children
        let appItemStatic props children = ReactHelpers.Elt AppItemStatic props children
        // remaining components

        // Typography presets
        let body1 props children = ReactHelpers.Elt Body1 props children
        let body1Strong props children = ReactHelpers.Elt Body1Strong props children
        let body1Stronger props children = ReactHelpers.Elt Body1Stronger props children
        let body2 props children = ReactHelpers.Elt Body2 props children
        let caption1 props children = ReactHelpers.Elt Caption1 props children
        let caption1Strong props children = ReactHelpers.Elt Caption1Strong props children
        let caption1Stronger props children = ReactHelpers.Elt Caption1Stronger props children
        let caption2 props children = ReactHelpers.Elt Caption2 props children
        let caption2Strong props children = ReactHelpers.Elt Caption2Strong props children
        let display props children = ReactHelpers.Elt Display props children
        let largeTitle props children = ReactHelpers.Elt LargeTitle props children
        let subtitle1 props children = ReactHelpers.Elt Subtitle1 props children
        let subtitle2 props children = ReactHelpers.Elt Subtitle2 props children
        let subtitle2Stronger props children = ReactHelpers.Elt Subtitle2Stronger props children
        let title1 props children = ReactHelpers.Elt Title1 props children
        let title2 props children = ReactHelpers.Elt Title2 props children
        let title3 props children = ReactHelpers.Elt Title3 props children

        // List
        let list props children = ReactHelpers.Elt List props children
        let listItem props children = ReactHelpers.Elt ListItem props children

        // Menu
        let menuDivider props children = ReactHelpers.Elt MenuDivider props children
        let menuGroup props children = ReactHelpers.Elt MenuGroup props children
        let menuGroupHeader props children = ReactHelpers.Elt MenuGroupHeader props children
        let menuItemCheckbox props children = ReactHelpers.Elt MenuItemCheckbox props children
        let menuItemLink props children = ReactHelpers.Elt MenuItemLink props children
        let menuItemRadio props children = ReactHelpers.Elt MenuItemRadio props children
        let menuItemSwitch props children = ReactHelpers.Elt MenuItemSwitch props children
        let menuSplitGroup props children = ReactHelpers.Elt MenuSplitGroup props children

        // Overflow
        let overflowDivider props children = ReactHelpers.Elt OverflowDivider props children
        let overflowReorderObserver props children = ReactHelpers.Elt OverflowReorderObserver props children

        // Avatar
        let avatarGroupItem props children = ReactHelpers.Elt AvatarGroupItem props children
        let avatarGroupPopover props children = ReactHelpers.Elt AvatarGroupPopover props children
        let presenceGroup props children = ReactHelpers.Elt PresenceGroup props children

        // Carousel
        let carousel props children = ReactHelpers.Elt Carousel props children
        let carouselAutoplayButton props children = ReactHelpers.Elt CarouselAutoplayButton props children
        let carouselButton props children = ReactHelpers.Elt CarouselButton props children
        let carouselCard props children = ReactHelpers.Elt CarouselCard props children
        let carouselNav props children = ReactHelpers.Elt CarouselNav props children
        let carouselNavButton props children = ReactHelpers.Elt CarouselNavButton props children
        let carouselNavContainer props children = ReactHelpers.Elt CarouselNavContainer props children
        let carouselNavImageButton props children = ReactHelpers.Elt CarouselNavImageButton props children
        let carouselSlider props children = ReactHelpers.Elt CarouselSlider props children
        let carouselViewport props children = ReactHelpers.Elt CarouselViewport props children

        // Color picker and swatches
        let colorArea props children = ReactHelpers.Elt ColorArea props children
        let colorPicker props children = ReactHelpers.Elt ColorPicker props children
        let colorSlider props children = ReactHelpers.Elt ColorSlider props children
        let colorSwatch props children = ReactHelpers.Elt ColorSwatch props children
        let alphaSlider props children = ReactHelpers.Elt AlphaSlider props children
        let emptySwatch props children = ReactHelpers.Elt EmptySwatch props children
        let imageSwatch props children = ReactHelpers.Elt ImageSwatch props children
        let swatchPicker props children = ReactHelpers.Elt SwatchPicker props children
        let swatchPickerRow props children = ReactHelpers.Elt SwatchPickerRow props children

        // Rating
        let rating props children = ReactHelpers.Elt Rating props children
        let ratingDisplay props children = ReactHelpers.Elt RatingDisplay props children
        let ratingItem props children = ReactHelpers.Elt RatingItem props children

        // Search and tags
        let searchBox props children = ReactHelpers.Elt SearchBox props children
        let tagPicker props children = ReactHelpers.Elt TagPicker props children
        let tagPickerButton props children = ReactHelpers.Elt TagPickerButton props children
        let tagPickerControl props children = ReactHelpers.Elt TagPickerControl props children
        let tagPickerGroup props children = ReactHelpers.Elt TagPickerGroup props children
        let tagPickerInput props children = ReactHelpers.Elt TagPickerInput props children
        let tagPickerList props children = ReactHelpers.Elt TagPickerList props children
        let tagPickerOption props children = ReactHelpers.Elt TagPickerOption props children
        let tagPickerOptionGroup props children = ReactHelpers.Elt TagPickerOptionGroup props children
        let optionGroup props children = ReactHelpers.Elt OptionGroup props children

        // Table extras
        let tableCellActions props children = ReactHelpers.Elt TableCellActions props children
        let tableResizeHandle props children = ReactHelpers.Elt TableResizeHandle props children

        // Teaching popover
        let teachingPopover props children = ReactHelpers.Elt TeachingPopover props children
        let teachingPopoverBody props children = ReactHelpers.Elt TeachingPopoverBody props children
        let teachingPopoverCarousel props children = ReactHelpers.Elt TeachingPopoverCarousel props children
        let teachingPopoverCarouselCard props children = ReactHelpers.Elt TeachingPopoverCarouselCard props children
        let teachingPopoverCarouselFooter props children = ReactHelpers.Elt TeachingPopoverCarouselFooter props children
        let teachingPopoverCarouselNav props children = ReactHelpers.Elt TeachingPopoverCarouselNav props children
        let teachingPopoverCarouselNavButton props children = ReactHelpers.Elt TeachingPopoverCarouselNavButton props children
        let teachingPopoverCarouselPageCount props children = ReactHelpers.Elt TeachingPopoverCarouselPageCount props children
        let teachingPopoverFooter props children = ReactHelpers.Elt TeachingPopoverFooter props children
        let teachingPopoverHeader props children = ReactHelpers.Elt TeachingPopoverHeader props children
        let teachingPopoverSurface props children = ReactHelpers.Elt TeachingPopoverSurface props children
        let teachingPopoverTitle props children = ReactHelpers.Elt TeachingPopoverTitle props children
        let teachingPopoverTrigger props children = ReactHelpers.Elt TeachingPopoverTrigger props children

        // Miscellaneous
        let ariaLiveAnnouncer props children = ReactHelpers.Elt AriaLiveAnnouncer props children
        let drawerFooter props children = ReactHelpers.Elt DrawerFooter props children
        let infoButton props children = ReactHelpers.Elt InfoButton props children
        let toastTrigger props children = ReactHelpers.Elt ToastTrigger props children
        let treeRootReset props children = ReactHelpers.Elt TreeRootReset props children

        // context providers (advanced usage)
        let accordionItemProvider props children = ReactHelpers.Elt AccordionItemProvider props children
        let accordionProvider props children = ReactHelpers.Elt AccordionProvider props children
        let announceProvider props children = ReactHelpers.Elt AnnounceProvider props children
        let avatarGroupProvider props children = ReactHelpers.Elt AvatarGroupProvider props children
        let breadcrumbProvider props children = ReactHelpers.Elt BreadcrumbProvider props children
        let carouselProvider props children = ReactHelpers.Elt CarouselProvider props children
        let columnIdContextProvider props children = ReactHelpers.Elt ColumnIdContextProvider props children
        let comboboxProvider props children = ReactHelpers.Elt ComboboxProvider props children
        let dataGridContextProvider props children = ReactHelpers.Elt DataGridContextProvider props children
        let dialogProvider props children = ReactHelpers.Elt DialogProvider props children
        let drawerProvider props children = ReactHelpers.Elt DrawerProvider props children
        let fieldContextProvider props children = ReactHelpers.Elt FieldContextProvider props children
        let idPrefixProvider props children = ReactHelpers.Elt IdPrefixProvider props children
        let listboxProvider props children = ReactHelpers.Elt ListboxProvider props children
        let menuGroupContextProvider props children = ReactHelpers.Elt MenuGroupContextProvider props children
        let menuListProvider props children = ReactHelpers.Elt MenuListProvider props children
        let menuProvider props children = ReactHelpers.Elt MenuProvider props children
        let menuTriggerContextProvider props children = ReactHelpers.Elt MenuTriggerContextProvider props children
        let messageBarContextProvider props children = ReactHelpers.Elt MessageBarContextProvider props children
        let navCategoryItemProvider props children = ReactHelpers.Elt NavCategoryItemProvider props children
        let navCategoryProvider props children = ReactHelpers.Elt NavCategoryProvider props children
        let navProvider props children = ReactHelpers.Elt NavProvider props children
        let portalMountNodeProvider props children = ReactHelpers.Elt PortalMountNodeProvider props children
        let positioningConfigurationProvider props children = ReactHelpers.Elt PositioningConfigurationProvider props children
        let radioGroupProvider props children = ReactHelpers.Elt RadioGroupProvider props children
        let ratingItemProvider props children = ReactHelpers.Elt RatingItemProvider props children
        let rendererProvider props children = ReactHelpers.Elt RendererProvider props children
        let ssrProvider props children = ReactHelpers.Elt SSRProvider props children
        let skeletonContextProvider props children = ReactHelpers.Elt SkeletonContextProvider props children
        let swatchPickerProvider props children = ReactHelpers.Elt SwatchPickerProvider props children
        let tabListProvider props children = ReactHelpers.Elt TabListProvider props children
        let tableContextProvider props children = ReactHelpers.Elt TableContextProvider props children
        let tableHeaderContextProvider props children = ReactHelpers.Elt TableHeaderContextProvider props children
        let tableRowIdContextProvider props children = ReactHelpers.Elt TableRowIdContextProvider props children
        let treeItemProvider props children = ReactHelpers.Elt TreeItemProvider props children
        let treeProvider props children = ReactHelpers.Elt TreeProvider props children
