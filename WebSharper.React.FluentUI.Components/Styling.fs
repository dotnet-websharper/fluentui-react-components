namespace WebSharper.FluentUI.React
open WebSharper
open WebSharper.JavaScript

[<JavaScript>]
module Styling = 
    module Themes =
        let teamsDarkTheme<'a> = JS.Import<'a>("teamsDarkTheme", "@fluentui/react-components")
 
        let teamsLightTheme<'a> = JS.Import<'a>("teamsLightTheme", "@fluentui/react-components")
 
        let teamsHighContrastTheme<'a> = JS.Import<'a>("teamsHighContrastTheme", "@fluentui/react-components")
 
        let webDarkTheme<'a> = JS.Import<'a>("webDarkTheme", "@fluentui/react-components")
 
        let webLightTheme<'a> = JS.Import<'a>("webLightTheme", "@fluentui/react-components")

    type Tokens = {
        colorNeutralForeground1:string
        colorNeutralForeground1Hover:string
        colorNeutralForeground1Pressed:string
        colorNeutralForeground1Selected:string
        colorNeutralForeground2:string
        colorNeutralForeground2Hover:string
        colorNeutralForeground2Pressed:string
        colorNeutralForeground2Selected:string
        colorNeutralForeground2BrandHover:string
        colorNeutralForeground2BrandPressed:string
        colorNeutralForeground2BrandSelected:string
        colorNeutralForeground3:string
        colorNeutralForeground3Hover:string
        colorNeutralForeground3Pressed:string
        colorNeutralForeground3Selected:string
        colorNeutralForeground3BrandHover:string
        colorNeutralForeground3BrandPressed:string
        colorNeutralForeground3BrandSelected:string
        colorNeutralForeground4:string
        colorNeutralForegroundDisabled:string
        colorBrandForegroundLink:string
        colorBrandForegroundLinkHover:string
        colorBrandForegroundLinkPressed:string
        colorBrandForegroundLinkSelected:string
        colorNeutralForeground2Link:string
        colorNeutralForeground2LinkHover:string
        colorNeutralForeground2LinkPressed:string
        colorNeutralForeground2LinkSelected:string
        colorCompoundBrandForeground1:string
        colorCompoundBrandForeground1Hover:string
        colorCompoundBrandForeground1Pressed:string
        colorNeutralForegroundOnBrand:string
        colorNeutralForegroundInverted:string
        colorNeutralForegroundInvertedHover:string
        colorNeutralForegroundInvertedPressed:string
        colorNeutralForegroundInvertedSelected:string
        colorNeutralForegroundInverted2:string
        colorNeutralForegroundStaticInverted:string
        colorNeutralForegroundInvertedLink:string
        colorNeutralForegroundInvertedLinkHover:string
        colorNeutralForegroundInvertedLinkPressed:string
        colorNeutralForegroundInvertedLinkSelected:string
        colorNeutralForegroundInvertedDisabled:string
        colorBrandForeground1:string
        colorBrandForeground2:string
        colorBrandForeground2Hover:string
        colorBrandForeground2Pressed:string
        colorNeutralForeground1Static:string
        colorBrandForegroundInverted:string
        colorBrandForegroundInvertedHover:string
        colorBrandForegroundInvertedPressed:string
        colorBrandForegroundOnLight:string
        colorBrandForegroundOnLightHover:string
        colorBrandForegroundOnLightPressed:string
        colorBrandForegroundOnLightSelected:string
        colorNeutralBackground1:string
        colorNeutralBackground1Hover:string
        colorNeutralBackground1Pressed:string
        colorNeutralBackground1Selected:string
        colorNeutralBackground2:string
        colorNeutralBackground2Hover:string
        colorNeutralBackground2Pressed:string
        colorNeutralBackground2Selected:string
        colorNeutralBackground3:string
        colorNeutralBackground3Hover:string
        colorNeutralBackground3Pressed:string
        colorNeutralBackground3Selected:string
        colorNeutralBackground4:string
        colorNeutralBackground4Hover:string
        colorNeutralBackground4Pressed:string
        colorNeutralBackground4Selected:string
        colorNeutralBackground5:string
        colorNeutralBackground5Hover:string
        colorNeutralBackground5Pressed:string
        colorNeutralBackground5Selected:string
        colorNeutralBackground6:string
        colorNeutralBackgroundInverted:string
        colorNeutralBackgroundStatic:string
        colorNeutralBackgroundAlpha:string
        colorNeutralBackgroundAlpha2:string
        colorSubtleBackground:string
        colorSubtleBackgroundHover:string
        colorSubtleBackgroundPressed:string
        colorSubtleBackgroundSelected:string
        colorSubtleBackgroundLightAlphaHover:string
        colorSubtleBackgroundLightAlphaPressed:string
        colorSubtleBackgroundLightAlphaSelected:string
        colorSubtleBackgroundInverted:string
        colorSubtleBackgroundInvertedHover:string
        colorSubtleBackgroundInvertedPressed:string
        colorSubtleBackgroundInvertedSelected:string
        colorTransparentBackground:string
        colorTransparentBackgroundHover:string
        colorTransparentBackgroundPressed:string
        colorTransparentBackgroundSelected:string
        colorNeutralBackgroundDisabled:string
        colorNeutralBackgroundInvertedDisabled:string
        colorNeutralStencil1:string
        colorNeutralStencil2:string
        colorNeutralStencil1Alpha:string
        colorNeutralStencil2Alpha:string
        colorBackgroundOverlay:string
        colorScrollbarOverlay:string
        colorBrandBackground:string
        colorBrandBackgroundHover:string
        colorBrandBackgroundPressed:string
        colorBrandBackgroundSelected:string
        colorCompoundBrandBackground:string
        colorCompoundBrandBackgroundHover:string
        colorCompoundBrandBackgroundPressed:string
        colorBrandBackgroundStatic:string
        colorBrandBackground2:string
        colorBrandBackground2Hover:string
        colorBrandBackground2Pressed:string
        colorBrandBackgroundInverted:string
        colorBrandBackgroundInvertedHover:string
        colorBrandBackgroundInvertedPressed:string
        colorBrandBackgroundInvertedSelected:string
        colorNeutralStrokeAccessible:string
        colorNeutralStrokeAccessibleHover:string
        colorNeutralStrokeAccessiblePressed:string
        colorNeutralStrokeAccessibleSelected:string
        colorNeutralStroke1:string
        colorNeutralStroke1Hover:string
        colorNeutralStroke1Pressed:string
        colorNeutralStroke1Selected:string
        colorNeutralStroke2:string
        colorNeutralStroke3:string
        colorNeutralStrokeSubtle:string
        colorNeutralStrokeOnBrand:string
        colorNeutralStrokeOnBrand2:string
        colorNeutralStrokeOnBrand2Hover:string
        colorNeutralStrokeOnBrand2Pressed:string
        colorNeutralStrokeOnBrand2Selected:string
        colorBrandStroke1:string
        colorBrandStroke2:string
        colorBrandStroke2Hover:string
        colorBrandStroke2Pressed:string
        colorBrandStroke2Contrast:string
        colorCompoundBrandStroke:string
        colorCompoundBrandStrokeHover:string
        colorCompoundBrandStrokePressed:string
        colorNeutralStrokeDisabled:string
        colorNeutralStrokeInvertedDisabled:string
        colorTransparentStroke:string
        colorTransparentStrokeInteractive:string
        colorTransparentStrokeDisabled:string
        colorNeutralStrokeAlpha:string
        colorNeutralStrokeAlpha2:string
        colorStrokeFocus1:string
        colorStrokeFocus2:string
        colorNeutralShadowAmbient:string
        colorNeutralShadowKey:string
        colorNeutralShadowAmbientLighter:string
        colorNeutralShadowKeyLighter:string
        colorNeutralShadowAmbientDarker:string
        colorNeutralShadowKeyDarker:string
        colorBrandShadowAmbient:string
        colorBrandShadowKey:string
        colorPaletteRedBackground1:string
        colorPaletteRedBackground2:string
        colorPaletteRedBackground3:string
        colorPaletteRedBorderActive:string
        colorPaletteRedBorder1:string
        colorPaletteRedBorder2:string
        colorPaletteRedForeground1:string
        colorPaletteRedForeground2:string
        colorPaletteRedForeground3:string
        colorPaletteRedForegroundInverted:string
        colorPaletteGreenBackground1:string
        colorPaletteGreenBackground2:string
        colorPaletteGreenBackground3:string
        colorPaletteGreenBorderActive:string
        colorPaletteGreenBorder1:string
        colorPaletteGreenBorder2:string
        colorPaletteGreenForeground1:string
        colorPaletteGreenForeground2:string
        colorPaletteGreenForeground3:string
        colorPaletteGreenForegroundInverted:string
        colorPaletteDarkOrangeBackground1:string
        colorPaletteDarkOrangeBackground2:string
        colorPaletteDarkOrangeBackground3:string
        colorPaletteDarkOrangeBorderActive:string
        colorPaletteDarkOrangeBorder1:string
        colorPaletteDarkOrangeBorder2:string
        colorPaletteDarkOrangeForeground1:string
        colorPaletteDarkOrangeForeground2:string
        colorPaletteDarkOrangeForeground3:string
        colorPaletteYellowBackground1:string
        colorPaletteYellowBackground2:string
        colorPaletteYellowBackground3:string
        colorPaletteYellowBorderActive:string
        colorPaletteYellowBorder1:string
        colorPaletteYellowBorder2:string
        colorPaletteYellowForeground1:string
        colorPaletteYellowForeground2:string
        colorPaletteYellowForeground3:string
        colorPaletteYellowForegroundInverted:string
        colorPaletteBerryBackground1:string
        colorPaletteBerryBackground2:string
        colorPaletteBerryBackground3:string
        colorPaletteBerryBorderActive:string
        colorPaletteBerryBorder1:string
        colorPaletteBerryBorder2:string
        colorPaletteBerryForeground1:string
        colorPaletteBerryForeground2:string
        colorPaletteBerryForeground3:string
        colorPaletteMarigoldBackground1:string
        colorPaletteMarigoldBackground2:string
        colorPaletteMarigoldBackground3:string
        colorPaletteMarigoldBorderActive:string
        colorPaletteMarigoldBorder1:string
        colorPaletteMarigoldBorder2:string
        colorPaletteMarigoldForeground1:string
        colorPaletteMarigoldForeground2:string
        colorPaletteMarigoldForeground3:string
        colorPaletteLightGreenBackground1:string
        colorPaletteLightGreenBackground2:string
        colorPaletteLightGreenBackground3:string
        colorPaletteLightGreenBorderActive:string
        colorPaletteLightGreenBorder1:string
        colorPaletteLightGreenBorder2:string
        colorPaletteLightGreenForeground1:string
        colorPaletteLightGreenForeground2:string
        colorPaletteLightGreenForeground3:string
        colorPaletteAnchorBackground2:string
        colorPaletteAnchorBorderActive:string
        colorPaletteAnchorForeground2:string
        colorPaletteBeigeBackground2:string
        colorPaletteBeigeBorderActive:string
        colorPaletteBeigeForeground2:string
        colorPaletteBlueBackground2:string
        colorPaletteBlueBorderActive:string
        colorPaletteBlueForeground2:string
        colorPaletteBrassBackground2:string
        colorPaletteBrassBorderActive:string
        colorPaletteBrassForeground2:string
        colorPaletteBrownBackground2:string
        colorPaletteBrownBorderActive:string
        colorPaletteBrownForeground2:string
        colorPaletteCornflowerBackground2:string
        colorPaletteCornflowerBorderActive:string
        colorPaletteCornflowerForeground2:string
        colorPaletteCranberryBackground2:string
        colorPaletteCranberryBorderActive:string
        colorPaletteCranberryForeground2:string
        colorPaletteDarkGreenBackground2:string
        colorPaletteDarkGreenBorderActive:string
        colorPaletteDarkGreenForeground2:string
        colorPaletteDarkRedBackground2:string
        colorPaletteDarkRedBorderActive:string
        colorPaletteDarkRedForeground2:string
        colorPaletteForestBackground2:string
        colorPaletteForestBorderActive:string
        colorPaletteForestForeground2:string
        colorPaletteGoldBackground2:string
        colorPaletteGoldBorderActive:string
        colorPaletteGoldForeground2:string
        colorPaletteGrapeBackground2:string
        colorPaletteGrapeBorderActive:string
        colorPaletteGrapeForeground2:string
        colorPaletteLavenderBackground2:string
        colorPaletteLavenderBorderActive:string
        colorPaletteLavenderForeground2:string
        colorPaletteLightTealBackground2:string
        colorPaletteLightTealBorderActive:string
        colorPaletteLightTealForeground2:string
        colorPaletteLilacBackground2:string
        colorPaletteLilacBorderActive:string
        colorPaletteLilacForeground2:string
        colorPaletteMagentaBackground2:string
        colorPaletteMagentaBorderActive:string
        colorPaletteMagentaForeground2:string
        colorPaletteMinkBackground2:string
        colorPaletteMinkBorderActive:string
        colorPaletteMinkForeground2:string
        colorPaletteNavyBackground2:string
        colorPaletteNavyBorderActive:string
        colorPaletteNavyForeground2:string
        colorPalettePeachBackground2:string
        colorPalettePeachBorderActive:string
        colorPalettePeachForeground2:string
        colorPalettePinkBackground2:string
        colorPalettePinkBorderActive:string
        colorPalettePinkForeground2:string
        colorPalettePlatinumBackground2:string
        colorPalettePlatinumBorderActive:string
        colorPalettePlatinumForeground2:string
        colorPalettePlumBackground2:string
        colorPalettePlumBorderActive:string
        colorPalettePlumForeground2:string
        colorPalettePumpkinBackground2:string
        colorPalettePumpkinBorderActive:string
        colorPalettePumpkinForeground2:string
        colorPalettePurpleBackground2:string
        colorPalettePurpleBorderActive:string
        colorPalettePurpleForeground2:string
        colorPaletteRoyalBlueBackground2:string
        colorPaletteRoyalBlueBorderActive:string
        colorPaletteRoyalBlueForeground2:string
        colorPaletteSeafoamBackground2:string
        colorPaletteSeafoamBorderActive:string
        colorPaletteSeafoamForeground2:string
        colorPaletteSteelBackground2:string
        colorPaletteSteelBorderActive:string
        colorPaletteSteelForeground2:string
        colorPaletteTealBackground2:string
        colorPaletteTealBorderActive:string
        colorPaletteTealForeground2:string
        colorStatusSuccessBackground1:string
        colorStatusSuccessBackground2:string
        colorStatusSuccessBackground3:string
        colorStatusSuccessForeground1:string
        colorStatusSuccessForeground2:string
        colorStatusSuccessForeground3:string
        colorStatusSuccessForegroundInverted:string
        colorStatusSuccessBorderActive:string
        colorStatusSuccessBorder1:string
        colorStatusSuccessBorder2:string
        colorStatusWarningBackground1:string
        colorStatusWarningBackground2:string
        colorStatusWarningBackground3:string
        colorStatusWarningForeground1:string
        colorStatusWarningForeground2:string
        colorStatusWarningForeground3:string
        colorStatusWarningForegroundInverted:string
        colorStatusWarningBorderActive:string
        colorStatusWarningBorder1:string
        colorStatusWarningBorder2:string
        colorStatusDangerBackground1:string
        colorStatusDangerBackground2:string
        colorStatusDangerBackground3:string
        colorStatusDangerForeground1:string
        colorStatusDangerForeground2:string
        colorStatusDangerForeground3:string
        colorStatusDangerForegroundInverted:string
        colorStatusDangerBorderActive:string
        colorStatusDangerBorder1:string
        colorStatusDangerBorder2:string
        borderRadiusNone:string
        borderRadiusSmall:string
        borderRadiusMedium:string
        borderRadiusLarge:string
        borderRadiusXLarge:string
        borderRadiusCircular:string
        fontFamilyBase:string
        fontFamilyMonospace:string
        fontFamilyNumeric:string
        fontSizeBase100:string
        fontSizeBase200:string
        fontSizeBase300:string
        fontSizeBase400:string
        fontSizeBase500:string
        fontSizeBase600:string
        fontSizeHero700:string
        fontSizeHero800:string
        fontSizeHero900:string
        fontSizeHero1000:string
        fontWeightRegular:string
        fontWeightMedium:string
        fontWeightSemibold:string
        fontWeightBold:string
        lineHeightBase100:string
        lineHeightBase200:string
        lineHeightBase300:string
        lineHeightBase400:string
        lineHeightBase500:string
        lineHeightBase600:string
        lineHeightHero700:string
        lineHeightHero800:string
        lineHeightHero900:string
        lineHeightHero1000:string
        shadow2:string
        shadow4:string
        shadow8:string
        shadow16:string
        shadow28:string
        shadow64:string
        shadow2Brand:string
        shadow4Brand:string
        shadow8Brand:string
        shadow16Brand:string
        shadow28Brand:string
        shadow64Brand:string
        strokeWidthThin:string
        strokeWidthThick:string
        strokeWidthThicker:string
        strokeWidthThickest:string
        spacingHorizontalNone:string
        spacingHorizontalXXS:string
        spacingHorizontalXS:string
        spacingHorizontalSNudge:string
        spacingHorizontalS:string
        spacingHorizontalMNudge:string
        spacingHorizontalM:string
        spacingHorizontalL:string
        spacingHorizontalXL:string
        spacingHorizontalXXL:string
        spacingHorizontalXXXL:string
        spacingVerticalNone:string
        spacingVerticalXXS:string
        spacingVerticalXS:string
        spacingVerticalSNudge:string
        spacingVerticalS:string
        spacingVerticalMNudge:string
        spacingVerticalM:string
        spacingVerticalL:string
        spacingVerticalXL:string
        spacingVerticalXXL:string
        spacingVerticalXXXL:string
        durationUltraFast:string
        durationFaster:string
        durationFast:string
        durationNormal:string
        durationGentle:string
        durationSlow:string
        durationSlower:string
        durationUltraSlow:string
        curveAccelerateMax:string
        curveAccelerateMid:string
        curveAccelerateMin:string
        curveDecelerateMax:string
        curveDecelerateMid:string
        curveDecelerateMin:string
        curveEasyEaseMax:string
        curveEasyEase:string
        curveLinear:string
    }
    
    let tokens = JS.Import<Tokens> ("tokens", "@fluentui/react-components")

    type MakeStyle = { displayName: string; styles: (string*obj) list }

    let makeStyles = JS.Import<obj -> obj>("makeStyles", "@fluentui/react-components")

    type BrandVariants = {
        ``10``: string
        ``20``: string
        ``30``: string
        ``40``: string
        ``50``: string
        ``60``: string
        ``70``: string
        ``80``: string
        ``90``: string
        ``100``: string
        ``110``: string
        ``120``: string
        ``130``: string
        ``140``: string
        ``150``: string
        ``160``: string
    }

    type TypographyStyle = {
        fontFamily: string
        fontSize: string
        fontWeight: string
        lineHeight: string
    }

    type TypographyStyles = {
        body1: TypographyStyle
        body1Strong: TypographyStyle
        body1Stronger: TypographyStyle
        body2: TypographyStyle
        caption1: TypographyStyle
        caption1Strong: TypographyStyle
        caption1Stronger: TypographyStyle
        caption2: TypographyStyle
        caption2Strong: TypographyStyle
        subtitle1: TypographyStyle
        subtitle2: TypographyStyle
        subtitle2Stronger: TypographyStyle
        title1: TypographyStyle
        title2: TypographyStyle
        title3: TypographyStyle
        largeTitle: TypographyStyle
        display: TypographyStyle
    }