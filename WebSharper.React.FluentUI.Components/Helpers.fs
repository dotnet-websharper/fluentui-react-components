﻿namespace WebSharper.FluentUI.React

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
            let item props children = ReactHelpers.Elt props children
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