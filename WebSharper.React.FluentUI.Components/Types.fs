namespace WebSharper.React.FluentUI

open WebSharper
open WebSharper.JavaScript
open WebSharper.React
[<JavaScript>]
module Types =
    type DataTabster = {
        [<Name "data-tabster">] dataTabster: string
    }

    type [<RequireQualifiedAccess>] InputDefaultAppearance = 
    | [<Constant "outline">] Outline 
    | [<Constant "filled-darker">] FilledDarker 
    | [<Constant "filled-lighter">] FilledLighter

    type OverridesContextValue_unstable = {
        inputDefaultAppearance: InputDefaultAppearance
    }

    type TagGroupDismissData = {
        dismissedTagValue: string
    }

    type FieldControlProps = {
        id: string
        [<Name "aria-labelledby">] AriaLabelledBy : string
        [<Name "aria-describedby">] AriaDescribedBy : string
        [<Name "aria-invalid">] AriaInvalid : bool
        [<Name "aria-required">] AriaRequired : bool
    }

    type PartitionBreadcrumbItemsOptions<'T> = {
        items: array<'T>
        maxDisplayedItems: int
        overflowIndex: int
    }

    type PartitionBreadcrumbItems<'T> = {
        endDisplayedItems: array<'T>
        overflowItems: array<'T>
        startDisplayedItems: array<'T>
    }

    module FieldControlProps =
        let toReactProperties (props: FieldControlProps): obj list =
            [
                Props.HTMLAttr.Id props.id
                Props.HTMLAttr.AriaLabelledby props.AriaLabelledBy
                Props.HTMLAttr.AriaDescribedBy props.AriaDescribedBy
                Props.HTMLAttr.AriaInvalid (string props.AriaInvalid)
                Props.HTMLAttr.AriaRequired props.AriaRequired
            ]

    type IgnoreKeyDown = {
        Tab: bool
        Escape: bool
        Enter: bool
        ArrowUp: bool
        ArrowDown: bool
        ArrowLeft: bool
        ArrowRight: bool
        PageUp: bool
        PageDown: bool
        Home: bool
        End: bool
    }

    type ModalAttributes = {
        modalAttributes: obj
        triggerAttributes: obj
    }

    type ModalTabsters = {
        modalAttributes: DataTabster
        triggerAttributes: DataTabster
    }

    type SyntheticEvent = {
        nativeEvent: Dom.MouseEvent
        currentTarget: HTMLElement
        target: HTMLElement
        bubbles: bool
        cancelable: bool
        defaultPrevented: bool
        eventPhase: int
        isTrusted: bool
        preventDefault: unit -> unit
        isDefaultPrevented: unit -> bool
        stopPropagation: unit -> unit
        isPropagationStopped: unit -> bool
        persist: unit -> unit
        timeStamp: int
        ``type``: string
    }

    type RefObject<'T> = {
        current: 'T option
    }

    /// Render function interface for providing overrideable render callbacks.
    type IRenderFunction<'P> = 'P -> ('P -> React.Element) -> React.Element

    type ValueProp<'t> = { value: 't }

    type OpenProp = { ``open``: bool }

    type SelectedProp = { selected: bool }

    type MenuCheckedValueChangeData = {
        /// The items for this value that are checked
        checkedItems: string array
        /// The name of the value
        name: string
    }

    type MenuOpenChangeData = {
        /// indicates whether the request for the open state was bubbled from a nested menu
        bubble: bool option
        /// Indicates whether the change of state was a keyboard interaction
        /// @deprecated
        /// This should not be used, since `Enter`, `Space` and click should be interpreted as the same thing as a click
        keyboard: bool option
        ``open``: bool
    }

    type MenuTriggerChildProps = {
        [<Name "aria-haspopup">] AriaHasPopup: string option
        [<Name "aria-expanded">] AriaExpanded: bool option
        id: string
        ref: React.Ref<obj>
        onMouseEnter: Dom.MouseEvent -> unit
        onMouseLeave: Dom.MouseEvent -> unit
        onMouseMove: Dom.MouseEvent -> unit
        onContextMenu: Dom.MouseEvent -> unit
    }

    type PopoverTriggerChildProps = {
        [<Name "aria-expanded">] AriaExpanded: bool
        ref: React.Ref<obj>
        onMouseEnter: Dom.MouseEvent -> unit
        onMouseLeave: Dom.MouseEvent -> unit
        onContextMenu: Dom.MouseEvent -> unit
    }

    type OffsetObject = {
        crossAxis: int option
        mainAxis: int
    }

    type OverflowBoundaryPadding = {
        top: int
        ``end``: int
        bottom: int
        start: int
    }

    type PositioningImperativeRef = {
        /// Updates the position imperatively.
        /// Useful when the position of the target changes from other factors than scrolling of window resize.
        updatePosition: unit -> unit
        /// Sets the target and updates positioning imperatively.
        /// Useful for avoiding double renders with the target option.
        setTarget: HTMLElement option -> unit
    }

    type OnVisibleChangeData = {
        visible: bool
    }

    type MountNode = {
        element: HTMLElement option
        className: string
    }

    type ChangeEvent = {
        target: Dom.EventTarget
    }

    type CheckState = | Checked | Unchecked | Mixed

    module CheckState =
        let fromData (arg: {| ``checked``: Union<string, bool> |}) =
            match arg.``checked`` with
            | Union1Of2 _ -> Mixed
            | Union2Of2 b -> if b then Checked else Unchecked

    module Checkbox =
        let toBool (arg: {| ``checked``: Union<string, bool> |}) =
            match arg.``checked`` with
            | Union1Of2 _ -> true
            | Union2Of2 b -> b

    type SwitchOnChangeData = {
        ``checked``: bool
    }

    type SpinButtonOnChangeData = {
        value: int option
        displayValue: string
    }

    type OptionOnSelectData = {
        optionValue: string option
        optionText: string option
        selectedOptions: string array
    }

    type ToolbarCheckedValueChangeData = {
        /// The items for this value that are checked
        checkedItems: string array
        /// The name of the value
        name: string
    }

    type PartitionAvatarGroupItems<'T> = {
        inlineItems: array<'T>
        overflowItems: array<'T>
    }

    type [<RequireQualifiedAccess>] DialogChange = 
    | [<Constant "escapeKeyDown">] EscapeKeyDown 
    | [<Constant "backdropClick">] BackdropClick 
    | [<Constant "triggerClick">] TriggerClick

    type DialogOpenChangeData<'TEvent> = {
        ``type``: DialogChange
        ``open``: bool
        event: 'TEvent
    }

    type FocusProp = {
        focus: unit -> unit
    }

    type OverflowMenuOptions<'Element> = {
        ref: React.Ref<'Element option>
        overflowCount: int
        isOverflowing: bool
    }

    type [<RequireQualifiedAccess>] OverflowGroupState = 
    | [<Constant "visible">] Visible 
    | [<Constant "hidden">] Hidden 
    | [<Constant "overflow">] Overflow

    type VirtualizerContextProps = {
        contextIndex:  int
        setContextIndex: int -> unit
    }

    type VirtualizerDataRef = {
        progressiveSizes: RefObject<int array>
        nodeSizes: RefObject<int array>
        setFlaggedIndex: int option -> unit
        currentIndex: RefObject<int>
    }

    type VirtualizerMeasure = {
        virtualizerLength: int
        bufferItems: int
        bufferSize: int
        scrollRef: Dom.Element -> unit
    }
    type MutableRefObject<'T> = {
        current: 'T
    }

    type [<RequireQualifiedAccess>] ScrollBehavior = 
    | [<Constant "auto">] Auto 
    | [<Constant "instant">] Instant 
    | [<Constant "smooth">] Smooth

    type ScrollToInterface = {
        scrollTo: int -> ScrollBehavior -> (int -> unit) -> unit
        virtualizerLength: RefObject<int>
        currentIndex: RefObject<int> option
    }

    type [<RequireQualifiedAccess>] AriaLivePoliteness = 
    | [<Constant "polite">] Polite 
    | [<Constant "assertive">] Assertive

    type AnnounceOptions = {
        politeness: AriaLivePoliteness
    }
    
    //DataGrid & Table 

    type TempSeq<'T> = { selectedItems: seq<'T> }

    type OnSelectionChangeData<'T> = { selectedItems: list<'T> }
    module TempSeq =
        let mkOnChangeData (v: TempSeq<'T>)=
            { selectedItems = v.selectedItems |> List.ofSeq }

    type [<RequireQualifiedAccess>] SortDirection = 
    | [<Constant "ascending">] Ascending 
    | [<Constant "descending">] Descending

    type TableColumnSizingOptions = {
        minWidth: int
        idealWidth: int
        padding: int
        defaultWidth: int
    }

    type ColumnResizeData<'TKeyType> = {
        columnId: 'TKeyType
        width: int
    }


    type [<RequireQualifiedAccess>] TableSelectionMode = 
    | [<Constant "single">] Single 
    | [<Constant "multiselect">] Multiselect

    type TableRowData<'T, 'TKeyType> = {
        /// User provided data
        item: 'T
        /// The row id, defaults to index position in the collection
        rowId: 'TKeyType
    }

    type TableColumnDefinition<'T, 'TKeyType> = {
        columnId: 'TKeyType
        compare: ('T * 'T) -> int
        renderHeaderCell: unit -> React.Element
        renderCell: 'T -> React.Element
    }


    type [<RequireQualifiedAccess>] DataGridFocusMode = 
    | [<Constant "none">] None 
    | [<Constant "cell">] Cell 
    | [<Constant "row_unstable">] RowUnstable 
    | [<Constant "composite">] Composite

    type [<RequireQualifiedAccess>] Appearance = 
    | [<Constant "brand">] Brand 
    | [<Constant "neutral">] Neutral 
    | [<Constant "none">] None

    type TableRowProps = {
        /// A table row can have different variants. These appearances are
        /// intended to be used with selection.
        appearance: Appearance
    }

    type FocusFinders = {
        findAllFocusable: HTMLElement -> ((HTMLElement -> bool) option) -> HTMLElement array
        findFirstFocusable: HTMLElement -> HTMLElement option
        findLastFocusable: HTMLElement -> HTMLElement option
        findNextFocusable: HTMLElement  -> HTMLElement -> HTMLElement option
        findPrevFocusable: HTMLElement -> HTMLElement -> HTMLElement
    }

    type DataGridContextValue = {
        /// How focus navigation will work in the datagrid
        focusMode: DataGridFocusMode
        /// Lets child components know if rows selection is enabled
        /// selectionMode prop enables row selection on the component
        selectableRows: bool
        /// Enables subtle selection style
        subtleSelection: bool
        /// Row appearance when selected
        selectionAppearance: TableRowProps
        /// Enables column resizing
        resizableColumns: bool option
        compositeRowTabsterAttribute: obj
    }

    // Toast

    type ToasterShortcuts = {
        focus: Dom.KeyboardEvent -> bool
    }

    type ToastOffset = {
        horizontal: int
        vertical: int
    }

    type [<RequireQualifiedAccess>] ToastPosition = 
    | [<Constant "top-end">] TopEnd
    | [<Constant "top-start">] TopStart
    | [<Constant "bottom-end">] BottomEnd
    | [<Constant "bottom-start">] BottomStart

    type [<RequireQualifiedAccess>] ToastPoliteness = 
    | [<Constant "assertive">] Assertive 
    | [<Constant "polite">] Polite

    type [<RequireQualifiedAccess>] ToastIntent = 
    | [<Constant "info">] Info 
    | [<Constant "success">] Success 
    | [<Constant "error">] Error 
    | [<Constant "warning">] Warning

    type [<RequireQualifiedAccess>] ToastStatus = 
    | [<Constant "queued">] Queued 
    | [<Constant "visible">] Visible 
    | [<Constant "dismissed">] Dismissed 
    | [<Constant "unmounted">] Unmounted

    type DispatchToastOptions = {
        /// Uniquely identifies a toast, used for update and dismiss operations
        toastId: string
        /// The position the toast should render to
        position: ToastPosition
        /// Toast content
        content: React.Element
        /// Auto dismiss timeout in milliseconds
        timeout: int
        /// Toast timeout pauses while focus is on another window
        pauseOnWindowBlur: bool
        /// Toast timeout pauses while user cursor is on the toast
        pauseOnHover: bool
        /// Higher priority toasts will be rendered before lower priority toasts
        priority: int
        /// Used to determine [aria-live](https://developer.mozilla.org/en-US/docs/Web/Accessibility/ARIA/ARIA_Live_Regions) narration
        /// This will override the intent prop
        politeness: ToastPoliteness
        /// Default toast types that determine the urgency or [aria-live](https://developer.mozilla.org/en-US/docs/Web/Accessibility/ARIA/ARIA_Live_Regions) narration
        /// The UI layer may use these intents to apply specific styling.
        intent: ToastIntent
        /// Additional data that needs to be passed to the toast
        data: obj
        /// Reports changes to the Toast lifecycle
        onStatusChange: (unit ->  ToastChangeData -> unit) option
    }
    and ToastChangeData = {
        root: obj list option
        /// Uniquely identifies a toast, used for update and dismiss operations
        toastId: string
        /// The position the toast should render to
        position: ToastPosition
        /// Toast content
        content: React.Element
        /// Auto dismiss timeout in milliseconds
        /// @default 3000
        timeout: int
        /// Toast timeout pauses while focus is on another window
        /// @default false
        pauseOnWindowBlur: bool
        /// Toast timeout pauses while user cursor is on the toast
        /// @default false
        pauseOnHover: bool
        /// Toast belongs to a specific toaster
        toasterId: string
        /// Higher priority toasts will be rendered before lower priority toasts
        priority: int
        /// Used to determine [aria-live](https://developer.mozilla.org/en-US/docs/Web/Accessibility/ARIA/ARIA_Live_Regions) narration
        /// This will override the intent prop
        politeness: ToastPoliteness
        /// Default toast types that determine the urgency or [aria-live](https://developer.mozilla.org/en-US/docs/Web/Accessibility/ARIA/ARIA_Live_Regions) narration
        /// The UI layer may use these intents to apply specific styling.
        /// @default info
        intent: ToastIntent
        /// Additional data that needs to be passed to the toast
        data: obj //TODO
        /// Reports changes to the Toast lifecycle
        onStatusChange: ToastChangeHandler option
        status: ToastStatus
        updateId: int
    }
    and ToastChangeHandler = Dom.MouseEvent -> ToastChangeData -> unit //TODO the first of the tuple is "null" in the docs
    
    type UpdateToastOptions = {
        root: obj list
        /// Uniquely identifies a toast, used for update and dismiss operations
        toastId: string
        /// The position the toast should render to
        position: ToastPosition
        /// Toast content
        content: React.Element
        /// Auto dismiss timeout in milliseconds
        /// @default 3000
        timeout: int
        /// Toast timeout pauses while focus is on another window
        /// @default false
        pauseOnWindowBlur: bool
        /// Toast timeout pauses while user cursor is on the toast
        /// @default false
        pauseOnHover: bool
        /// Toast belongs to a specific toaster
        toasterId: string
        /// Higher priority toasts will be rendered before lower priority toasts
        priority: int
        /// Used to determine [aria-live](https://developer.mozilla.org/en-US/docs/Web/Accessibility/ARIA/ARIA_Live_Regions) narration
        /// This will override the intent prop
        politeness: ToastPoliteness
        /// Default toast types that determine the urgency or [aria-live](https://developer.mozilla.org/en-US/docs/Web/Accessibility/ARIA/ARIA_Live_Regions) narration
        /// The UI layer may use these intents to apply specific styling.
        /// @default info
        intent: ToastIntent
        /// Additional data that needs to be passed to the toast
        data: obj
        /// Reports changes to the Toast lifecycle
        onStatusChange: ToastChangeHandler option
    }

    type ToastController = {
        dispatchToast: React.Element * obj -> unit
        /// Takes a `toastId`
        dismissToast: string -> unit
        dismissAllToasts: unit -> unit
        updateToast: obj -> unit
        /// Takes a `toastId`
        pauseToast: string -> unit
        /// Takes a `toastId`
        playToast: string -> unit
    }

    // Calendar & Date

    type DateRangeType = 
    | Day 
    | Week 
    | Month 
    | WorkWeek

    type [<RequireQualifiedAccess>] DatePickerErrorType = 
    | [<Constant "invalid-input">] InvalidInput
    | [<Constant "out-of-bounds">] OutOfBounds
    | [<Constant "required-input">] RequiredInput

    type DatePickerValidationResultData = {
        /// The error found when validating the input.
        error: DatePickerErrorType option
    }

    module DatePickerValidationResultData =
        let fromString (result: {| error: string option |}) =
            match result.error with
            | Some "invalid-input" -> { error= Some DatePickerErrorType.InvalidInput }
            | Some "out-of-bounds" -> { error= Some DatePickerErrorType.OutOfBounds }
            | Some "required-input" -> { error= Some DatePickerErrorType.RequiredInput }
            | _ -> { error = None }

    type DatePickerErrorStrings = {
        [<Name "invalid-input">] InvalidInput : string
        [<Name "out-of-bounds">] OutOfBounds : string
        [<Name "required-input">] RequiredInput: string
    }

    module DatePickerErrorStrings =

        let fromErrorTypeOption (error: DatePickerErrorType option) =
            match error with
            | Some DatePickerErrorType.InvalidInput-> "Invalid date format"
            | Some DatePickerErrorType.OutOfBounds -> "Date is out of bounds"
            | Some DatePickerErrorType.RequiredInput -> "Field is required"
            | _ -> ""

    type DateGridStrings = {
        /// An array of strings for the full names of months.
        /// The array is 0-based, so months[0] should be the full name of January.
        months: string array
        /// An array of strings for the short names of months.
        /// The array is 0-based, so shortMonths[0] should be the short name of January.
        shortMonths: string array
        /// An array of strings for the full names of days of the week.
        /// The array is 0-based, so days[0] should be the full name of Sunday.
        days: string array
        /// An array of strings for the initials of the days of the week.
        /// The array is 0-based, so days[0] should be the initial of Sunday.
        shortDays: string array
    }

    type DateFormatting = {
        /// Get a localized string for a day.
        /// The text for each day of the month
        formatDay: System.DateTime -> string
        /// Get a localized string for a month.
        formatMonth: System.DateTime -> DateGridStrings -> string
        /// Get a localized string for a year.
        /// The "2023" text at top of month picker
        formatYear: System.DateTime -> string
        /// Get a localized string for a month, day, and year.
        formatMonthDayYear: System.DateTime -> DateGridStrings -> string
        /// Get a localized string for a month and year.
        /// The "September 2023" text at top of calendar
        formatMonthYear: System.DateTime -> DateGridStrings -> string
    }

    type CalendarStrings = {
        /// String to render for button to direct the user to today's date.
        goToToday: string
        /// Aria-label for the "previous month" button in day picker.
        prevMonthAriaLabel: string option
        /// Aria-label for the "next month" button in day picker.
        nextMonthAriaLabel: string option
        /// Aria-label for the "previous year" button in month picker.
        prevYearAriaLabel: string option
        /// Aria-label for the "next year" button in month picker.
        nextYearAriaLabel: string option
        /// Aria-label for the "previous year range" button in year picker.
        prevYearRangeAriaLabel: string option
        /// Aria-label for the "next year range" button in year picker.
        nextYearRangeAriaLabel: string option
        /// Aria-label format string for the header button in the month picker. Should have 1 string param, e.g. "`{0}`,
        /// select to change the year". This aria-label will only be applied if the year picker is enabled; otherwise
        /// the label will default to the header string, e.g. "2019".
        monthPickerHeaderAriaLabel: string option
        /// Aria-label format string for the header button in the year picker.
        /// Should have 1 string param, e.g. "`{0}`, select to change the month"
        yearPickerHeaderAriaLabel: string option
        /// Aria-label for the "close" button.
        closeButtonAriaLabel: string option
        /// Aria-label format string for the week number header. Should have 1 string param, e.g. "week number `{0}`"
        weekNumberFormatString: string option
        /// Aria-label format string for the currently selected date. Should have 1 string param, e.g. "Selected date `{0}`"
        selectedDateFormatString: string option
        /// Aria-label format string for today's date. Should have 1 string param, e.g. "Today's date `{0}`"
        todayDateFormatString: string option
        /// Aria-label for when a date is marked
        dayMarkedAriaLabel: string option
        months: string array
        shortMonths: string array
        days: string array
        shortDays: string array
    }

    type CalendarDayGridStyles = {
        /// The style for the root div
        wrapper: string
        /// The style for the table containing the grid
        table: string
        /// The style to apply to the grid cells for days
        dayCell: string
        /// The style to apply to grid cells for days in the selected range
        daySelected: string
        /// The style to apply to row around weeks
        weekRow: string
        /// The style to apply to the column headers above the weeks
        weekDayLabelCell: string
        /// The style to apply to grid cells for week numbers
        weekNumberCell: string
        /// The style to apply to individual days that are outside the min/max date range
        dayOutsideBounds: string
        /// The style to apply to individual days that are outside the current month
        dayOutsideNavigatedMonth: string
        /// The style to apply to the button element within the day cells
        dayButton: string
        /// The style to apply to the individual button element that matches the "today" parameter
        dayIsToday: string
        /// The style applied to the first placeholder week used during transitions
        firstTransitionWeek: string
        /// The style applied to the last placeholder week used during transitions
        lastTransitionWeek: string
        /// The style applied to the marker on days to mark as important
        dayMarker: string
    }

    type  FirstWeekOfYear = | FirstDay  | FirstFullWeek | FirstFourDayWeek

    // Tree & FlatTree
    type TreeOpen = | ExpandIconClick | Click | Enter | ArrowRight | ArrowLeft

    type TreeOpenChangeData<'T, 'TEvent> = {
        ``open``: bool
        openItems: seq<'T>
        value: 'T
        target: HTMLElement
        event: 'TEvent
        ``type``: TreeOpen
    }

    type TreeNavigationData_unstable<'T, 'TEvent> = {
        target: HTMLElement
        value: 'T
        event: 'TEvent
        ``type``: TreeOpen
    }

    type [<RequireQualifiedAccess>] TreeItemType = 
    | [<Constant "leaf">] Leaf 
    | [<Constant "branch">] Branch

    type HeadlessTreeItemProps<'T> = {
        value: 'T
        itemType: TreeItemType
        parentValue: 'T option
        [<Name "aria-level">] AriaLevel: int
        [<Name "aria-setsize">] AriaSetSize: int
        [<Name "aria-posinset">] AriaPosInset: int
    }

    type TreeCheckedChangeData<'T, 'TEvent> = {
        value: 'T
        checkedItems: 'T list //TODO
        target: HTMLElement
        event: 'TEvent
        ``type``: TreeOpen
        selectionMode: string
        ``checked``: string
    }

    type FlatTreeProps<'T, 'TEvent, 'K> = {
        // This refers to a list of ids of opened tree items.
        // Controls the state of the open tree items.
        // These property is ignored for subtrees.
        openItems: seq<'T>
        //  Callback fired when the component changes value from open state.
        //  These property is ignored for subtrees.
        //  Event - a React's Synthetic event
        //  Data - A data object with relevant information, such as open value and type of interaction that created the event.
        onOpenChange: 'TEvent -> TreeOpenChangeData<'T, 'TEvent> -> unit
        //  Callback fired when navigation happens inside the component.
        //  These property is ignored for subtrees.
        //  FIXME: This method is not ideal, as navigation should be handled internally by tabster.
        //  Event - a React's Synthetic event
        //  Data - A data object with relevant information,

        onNavigation: 'TEvent -> TreeNavigationData_unstable<'T, 'TEvent> -> unit
        // This refers to the selection mode of the tree.
        // - undefined: No selection can be done.
        // - 'single': Only one tree item can be selected, radio buttons are rendered.
        // - 'multiselect': Multiple tree items can be selected, checkboxes are rendered.
        selectionMode: string
        //  This refers to a list of ids of checked tree items, or a list of tuples of ids and checked state.
        //  Controls the state of the checked tree items.
        //  These property is ignored for subtrees.
        checkedItems: seq<'K>
        onCheckedChange: 'TEvent -> TreeCheckedChangeData<'T, 'TEvent> -> unit
        ref: React.Ref<HTMLElement(*.Types.HTMLDivElement*)>
    }

    type HeadlessTreeItem<'T> = {
        level: int
        index: int
        position: int
        childrenValues: 'T array
        value: 'T
        parentValue: 'T
        itemType: TreeItemType
        getTreeItemProps: unit -> HeadlessTreeItemProps<'T>
    }

    type HeadlessFlatTree<'T, 'TEvent, 'K> = {
        /// returns the properties required for the Tree component to work properly.
        /// That includes:
        /// `openItems`, `onOpenChange`, `onNavigation_unstable` and `ref`
        getTreeProps: unit -> FlatTreeProps<'T, 'TEvent, 'K>
        /// internal method used to react to an `onNavigation` event.
        /// This method ensures proper navigation on keyboard and mouse interaction.
        /// In case of virtualization it might be required to cancel default provided `onNavigation`
        /// event and then call this method manually.
        /// const handleNavigation = (event, data) => {
        ///   event.preventDefault();
        ///   const nextItem = tree.getNextNavigableItem(data);
        ///   // scroll to item using virtualization scroll mechanism
        ///   if (nextItem && tree.getElementFromItem(nextItem)) {
        ///     listRef.current.scrollToItem(nextItem.index);
        ///   }
        ///   // wait for scrolling to happen and then invoke navigate method
        ///   requestAnimationFrame(() => {
        ///     tree.navigate(data);
        ///   });
        /// };
        navigate: TreeNavigationData_unstable<'T, 'TEvent> -> unit
        /// returns next item to be focused on a navigation.
        /// This method is provided to decouple the element that needs to be focused from
        ///  the action of focusing it itself.
        /// On the case of TypeAhead navigation this method returns the current item.
        getNextNavigableItem: HeadlessTreeItem<'T> array -> TreeNavigationData_unstable<'T, 'TEvent> -> HeadlessTreeItem<'T> option
        /// similar to getElementById but for FlatTreeItems
        getElementFromItem: HeadlessTreeItem<'T> -> HTMLElement
        /// an iterable containing all visually available flat tree items
        items: unit -> seq<HeadlessTreeItem<'T>>
    }


    type [<AllowNullLiteral>] HeadlessFlatTreeOptions<'T, 'TEvent> =
        /// Callback fired when the component changes value from open state.
        /// These property is ignored for subtrees.
        /// @param event - a React's Synthetic event
        /// @param data - A data object with relevant information,
        /// such as open value and type of interaction that created the event.
        abstract onOpenChange: ('TEvent -> TreeOpenChangeData<'T, 'TEvent> -> unit) with get, set
        /// Callback fired when navigation happens inside the component.
        /// These property is ignored for subtrees.
        /// FIXME: This method is not ideal, as navigation should be handled internally by tabster.
        /// @param event - a React's Synthetic event
        /// @param data - A data object with relevant information,
        abstract onNavigation: ('TEvent -> TreeNavigationData_unstable<'T, 'TEvent> -> unit) with get, set
        /// This refers to the selection mode of the tree.
        /// - undefined: No selection can be done.
        /// - 'single': Only one tree item can be selected, radio buttons are rendered.
        /// - 'multiselect': Multiple tree items can be selected, checkboxes are rendered.
        /// @default undefined
        abstract selectionMode: string with get, set
        /// Callback fired when the component changes value from checked state.
        /// These property is ignored for subtrees.
        /// @param event - a React's Synthetic event
        /// @param data - A data object with relevant information,
        /// such as checked value and type of interaction that created the event.
        abstract onCheckedChange: ('TEvent -> TreeCheckedChangeData<'T, 'TEvent> -> unit) with get, set
        /// This refers to a list of ids of opened tree items.
        /// Controls the state of the open tree items.
        /// These property is ignored for subtrees.
        abstract openItems: seq<'T> with get, set
        /// This refers to a list of ids of default opened items.
        /// This property is ignored for subtrees.
        abstract defaultOpenItems: seq<'T> with get, set
        /// This refers to a list of ids of checked tree items, or a list of tuples of ids and checked state.
        /// Controls the state of the checked tree items.
        /// These property is ignored for subtrees.
        abstract checkedItems: seq<'T * string> with get, set
        abstract defaultCheckedItems: seq<'T * string> with get, set

    type HeadlessFlatTree<'T, 'TEvent> = {
        /// returns the properties required for the Tree component to work properly.
        /// That includes:
        /// `openItems`, `onOpenChange`, `onNavigation_unstable` and `ref`
        getTreeProps: unit -> HeadlessFlatTreeOptions<'T, 'TEvent>
        /// internal method used to react to an `onNavigation` event.
        /// This method ensures proper navigation on keyboard and mouse interaction.
        /// In case of virtualization it might be required to cancel default provided `onNavigation`
        /// event and then call this method manually.
        /// const handleNavigation = (event, data) => {
        ///   event.preventDefault();
        ///   const nextItem = tree.getNextNavigableItem(data);
        ///   // scroll to item using virtualization scroll mechanism
        ///   if (nextItem && tree.getElementFromItem(nextItem)) {
        ///     listRef.current.scrollToItem(nextItem.index);
        ///   }
        ///   // wait for scrolling to happen and then invoke navigate method
        ///   requestAnimationFrame(() => {
        ///     tree.navigate(data);
        ///   });
        /// };
        navigate: TreeNavigationData_unstable<'T, 'TEvent> -> unit
        /// returns next item to be focused on a navigation.
        /// This method is provided to decouple the element that needs to be focused from
        ///  the action of focusing it itself.
        /// On the case of TypeAhead navigation this method returns the current item.
        getNextNavigableItem: HeadlessTreeItem<'T> array -> TreeNavigationData_unstable<'T, 'TEvent> -> HeadlessTreeItem<'T> option
        /// similar to getElementById but for FlatTreeItems
        getElementFromItem: HeadlessTreeItem<'T> -> HTMLElement
        /// an iterable containing all visually available flat tree items
        items: unit -> seq<HeadlessTreeItem<'T>>
    }

    // ----------------------------------- TimePicker --------------------------------------------

    type [<RequireQualifiedAccess>] TimePickerErrorType = 
    | [<Constant "invalid-input">] InvalidInput 
    | [<Constant "out-of-bounds">] OutOfBounds 
    | [<Constant "required-input">] RequiredInput

    type TimeStringValidationResult = {
        date: System.DateTime option
        errorType: TimePickerErrorType
    }

    type TimeSelectionData = {
        /// The Date object associated with the selected option. For freeform TimePicker it can also be the Date object parsed from the user input.
        selectedTime: System.DateTime option
        /// The display text for the selected option. For freeform TimePicker it can also be the value in user input.
        selectedTimeText: string option
        /// The error type for the selected option.
        errorType: TimePickerErrorType option
    }

    module TimeSelectionData =
        let parse (data: {| selectedTime: System.DateTime option; selectedTimeText: string option; errorType: string option|}) =
            let newErrorType =
                match data.errorType with
                | Some "invalid-input" -> Some TimePickerErrorType.InvalidInput
                | Some "out-of-bounds" -> Some TimePickerErrorType.OutOfBounds
                | Some "required-input" -> Some TimePickerErrorType.RequiredInput
                | _ -> None

            {
                selectedTime = data.selectedTime
                selectedTimeText = data.selectedTimeText
                errorType = newErrorType
            }

    type [<RequireQualifiedAccess>] MotionType = 
    | [<Constant "entering">] Entering 
    | [<Constant "entered">] Entered 
    | [<Constant "idle">] Idle 
    | [<Constant "exiting">] Exiting 
    | [<Constant "exited">] Exited 
    | [<Constant "unmounted">] Unmounted

    type MotionState = {
        /// Ref to the element.
        ref: React.Ref<HTMLElement option>
        /// Current state of the element.
        /// - `unmounted` - The element is not yet rendered or can be safely removed from the DOM.
        /// - `entering` - The element is performing enter animation.
        /// - `entered` - The element has finished enter animation.
        /// - `idle` - The element is currently not animating, but rendered on screen.
        /// - `exiting` - The element is performing exit animation.
        /// - `exited` - The element has finished exit animation.
        ``type``: MotionType
        /// Indicates whether the component can be rendered.
        /// Useful to render the element before animating it or to remove it from the DOM after exit animation.
        canRender: bool
        /// Indicates whether the component is ready to receive a CSS transition className.
        /// Useful to apply CSS transitions when the element is mounted and ready to be animated.
        active: bool
    }