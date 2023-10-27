﻿// ReSharper disable InconsistentNaming
// ReSharper disable IdentifierTypo
// ReSharper disable CommentTypo

namespace FFXIVClientStructs.FFXIV.Client.UI.Misc;

/// <summary>
/// ConfigOption indexes for use with ConfigModule.
/// This enum will be incorrect after any patch that adds or removes any config options.
/// </summary>
public enum ConfigOption : short
{
	Invalid = -1,
	None = 0,
	// System Config
	// System - FINAL FANTASY XIV Config File
	// System - Version
	GuidVersion = 2,
	ConfigVersion = 3,
	Language = 4,
	Region = 5,
	// System - Network Settings
	UPnP = 7,
	Port = 8,
	LastLogin0 = 9,
	LastLogin1 = 10,
	WorldId = 11,
	ServiceIndex = 12,
	DktSessionId = 13,
	// System - Display Settings
	MainAdapter = 15,
	ScreenLeft = 16,
	ScreenTop = 17,
	ScreenWidth = 18,
	ScreenHeight = 19,
	ScreenMode = 20,
	FullScreenWidth = 21,
	FullScreenHeight = 22,
	Refreshrate = 23,
	Fps = 24,
	AntiAliasing = 25,
	FPSInActive = 26,
	ResoMouseDrag = 27,
	MouseOpeLimit = 28,
	LangSelectSub = 29,
	Gamma = 30,
	UiBaseScale = 31,
	CharaLight = 32,
	UiHighScale = 33,
	// System - Graphics Settings
	TextureFilterQuality = 35,
	TextureAnisotropicQuality = 36,
	SSAO = 37,
	Glare = 38,
	DistortionWater = 39,
	DepthOfField = 40,
	RadialBlur = 42,
	Vignetting = 43,
	GrassQuality = 44,
	TranslucentQuality = 45,
	ShadowVisibilityType = 46,
	ShadowSoftShadowType = 47,
	ShadowTextureSizeType = 48,
	ShadowCascadeCountType = 49,
	LodType = 50,
	StreamingType = 51,
	GeneralQuality = 52,
	OcclusionCulling = 53,
	ShadowLOD = 54,
	PhysicsType = 59,
	MapResolution = 60,
	ShadowVisibilityTypeSelf = 61,
	ShadowVisibilityTypeParty = 62,
	ShadowVisibilityTypeOther = 63,
	ShadowVisibilityTypeEnemy = 64,
	PhysicsTypeSelf = 65,
	PhysicsTypeParty = 66,
	PhysicsTypeOther = 67,
	PhysicsTypeEnemy = 68,
	ReflectionType = 69,
	ScreenShotImageType = 70,
	// System - Sound Settings
	IsSoundDisable = 72,
	IsSoundAlways = 73,
	IsSoundBgmAlways = 74,
	IsSoundSeAlways = 75,
	IsSoundVoiceAlways = 76,
	IsSoundSystemAlways = 77,
	IsSoundEnvAlways = 78,
	IsSoundPerformAlways = 79,
	// System - Font Settings
	// System - GamePad Settings
	PadGuid = 82,
	InstanceGuid = 83,
	ProductGuid = 84,
	DeadArea = 85,
	Alias = 86,
	AlwaysInput = 87,
	ForceFeedBack = 88,
	PadPovInput = 89,
	PadMode = 90,
	PadAvailable = 91,
	PadReverseConfirmCancel = 92,
	PadSelectButtonIcon = 93,
	PadMouseMode = 94,
	TextPasteEnable = 95,
	EnablePsFunction = 96,
	WaterWet = 97,
	DisplayObjectLimitType = 98,
	WindowDispNum = 99,
	ScreenShotDir = 100,
	// System - Graphics Settings DX11
	AntiAliasing_DX11 = 102,
	TextureFilterQuality_DX11 = 103,
	TextureAnisotropicQuality_DX11 = 104,
	SSAO_DX11 = 105,
	Glare_DX11 = 106,
	DistortionWater_DX11 = 107,
	DepthOfField_DX11 = 108,
	RadialBlur_DX11 = 109,
	Vignetting_DX11 = 110,
	GrassQuality_DX11 = 111,
	TranslucentQuality_DX11 = 112,
	ShadowSoftShadowType_DX11 = 113,
	ShadowTextureSizeType_DX11 = 114,
	ShadowCascadeCountType_DX11 = 115,
	LodType_DX11 = 116,
	OcclusionCulling_DX11 = 117,
	ShadowLOD_DX11 = 118,
	MapResolution_DX11 = 119,
	ShadowVisibilityTypeSelf_DX11 = 120,
	ShadowVisibilityTypeParty_DX11 = 121,
	ShadowVisibilityTypeOther_DX11 = 122,
	ShadowVisibilityTypeEnemy_DX11 = 123,
	PhysicsTypeSelf_DX11 = 124,
	PhysicsTypeParty_DX11 = 125,
	PhysicsTypeOther_DX11 = 126,
	PhysicsTypeEnemy_DX11 = 127,
	ReflectionType_DX11 = 128,
	WaterWet_DX11 = 129,
	ParallaxOcclusion_DX11 = 130,
	Tessellation_DX11 = 131,
	GlareRepresentation_DX11 = 132,
	UiSystemEnlarge = 133,
	SoundPadSeType = 134,
	SoundPad = 135,
	IsSoundPad = 136,
	TouchPadMouse = 137,
	TouchPadCursorSpeed = 138,
	TouchPadButtonExtension = 139,
	TouchPadButton_Left = 140,
	TouchPadButton_Right = 141,
	RemotePlayRearTouchpadEnable = 142,
	SupportButtonAutorunEnable = 143,
	R3ButtonWindowScalingEnable = 144,
	AutoAfkSwitchingTime = 145,
	AutoChangeCameraMode = 146,
	AccessibilitySoundVisualEnable = 147,
	AccessibilitySoundVisualDispSize = 148,
	AccessibilitySoundVisualPermeabilityRate = 149,
	AccessibilityColorBlindFilterEnable = 150,
	AccessibilityColorBlindFilterType = 151,
	AccessibilityColorBlindFilterStrength = 152,
	// System - Mouse Settings
	MouseAutoFocus = 154,
	// System - UI Settings
	FPSDownAFK = 156,
	IdlingCameraAFK = 157,
	MouseSpeed = 178,
	CameraZoom = 200,
	DynamicRezoType = 315,
	// System - Move Operation
	Is3DAudio = 322,
	BattleEffect = 324,
	BGEffect = 325,
	ColorThemeType = 705,
	SystemMouseOperationSoftOn = 793,
	SystemMouseOperationTrajectory = 794,
	SystemMouseOperationCursorScaling = 795,
	HardwareCursorSize = 796,
	UiAssetType = 797,
	FellowshipShowNewNotice = 815,
	// System - Cutscene Settings
	CutsceneMovieVoice = 828,
	CutsceneMovieCaption = 829,
	CutsceneMovieOpening = 830,
	// System - SoundPlay Settings
	SoundMaster = 833,
	SoundBgm = 834,
	SoundSe = 835,
	SoundVoice = 836,
	SoundEnv = 837,
	SoundSystem = 838,
	SoundPerform = 839,
	SoundPlayer = 840,
	SoundParty = 841,
	SoundOther = 842,
	IsSndMaster = 843,
	IsSndBgm = 844,
	IsSndSe = 845,
	IsSndVoice = 846,
	IsSndEnv = 847,
	IsSndSystem = 848,
	IsSndPerform = 849,
	SoundDolby = 850,
	SoundMicpos = 851,
	SoundChocobo = 852,
	SoundFieldBattle = 853,
	SoundCfTimeCount = 854,
	SoundHousing = 855,
	SoundEqualizerType = 856,
	// System - GamePad Button Settings
	PadButton_L2 = 858,
	PadButton_R2 = 859,
	PadButton_L1 = 860,
	PadButton_R1 = 861,
	PadButton_Triangle = 862,
	PadButton_Circle = 863,
	PadButton_Cross = 864,
	PadButton_Square = 865,
	PadButton_Select = 866,
	PadButton_Start = 867,
	PadButton_LS = 868,
	PadButton_RS = 869,
	PadButton_L3 = 870,
	PadButton_R3 = 871,
	// System - CUSTOM CONFIGURATION


	// Ui Config
	BattleEffectSelf = 55,
	BattleEffectParty = 56,
	BattleEffectOther = 57,
	BattleEffectPvPEnemyPc = 58,
	// Ui - GamePad Settings
	// Ui - UI Settings
	// Ui - Charcter Settings
	WeaponAutoPutAway = 159,
	WeaponAutoPutAwayTime = 160,
	LipMotionType = 161,
	// Ui - Game Camera Settings
	FirstPersonDefaultYAngle = 163,
	FirstPersonDefaultZoom = 164,
	FirstPersonDefaultDistance = 165,
	ThirdPersonDefaultYAngle = 166,
	ThirdPersonDefaultZoom = 167,
	ThirdPersonDefaultDistance = 168,
	LockonDefaultYAngle = 169,
	LockonDefaultZoom = 170,
	LockonDefaultZoom_171 = 171,
	CameraProductionOfAction = 195,
	FPSCameraInterpolationType = 196,
	FPSCameraVerticalInterpolation = 197,
	LegacyCameraCorrectionFix = 198,
	LegacyCameraType = 199,
	EventCameraAutoControl = 201,
	CameraLookBlinkType = 202,
	IdleEmoteTime = 203,
	IdleEmoteRandomType = 204,
	CutsceneSkipIsShip = 205,
	CutsceneSkipIsContents = 206,
	CutsceneSkipIsHousing = 207,
	PetTargetOffInCombat = 299,
	GroundTargetFPSPosX = 300,
	GroundTargetFPSPosY = 301,
	GroundTargetTPSPosX = 302,
	GroundTargetTPSPosY = 303,
	TargetDisableAnchor = 304,
	TargetCircleClickFilterEnableNearestCursor = 305,
	TargetEnableMouseOverSelect = 306,
	GroundTargetCursorCorrectType = 307,
	GroundTargetActionExcuteType = 308,
	AutoNearestTarget = 313,
	AutoNearestTargetType = 314,
	RightClickExclusionPC = 316,
	RightClickExclusionBNPC = 317,
	RightClickExclusionMinion = 318,
	TurnSpeed = 321,
	FootEffect = 323,
	LegacySeal = 326,
	GBarrelDisp = 327,
	EgiMirageTypeGaruda = 328,
	EgiMirageTypeTitan = 329,
	EgiMirageTypeIfrit = 330,
	BahamutSize = 331,
	PetMirageTypeCarbuncleSupport = 332,
	PhoenixSize = 333,
	GarudaSize = 334,
	TitanSize = 335,
	IfritSize = 336,
	TimeMode = 337,
	Time12 = 338,
	TimeEorzea = 339,
	TimeLocal = 340,
	TimeServer = 341,
	ActiveLS_H = 342,
	ActiveLS_L = 343,
	HotbarLock = 345,
	HotbarDispRecastTime = 347,
	HotbarCrossContentsActionEnableInput = 348,
	HotbarDispRecastTimeDispType = 349,
	ExHotbarChangeHotbar1 = 362,
	HotbarCommon01 = 364,
	HotbarCommon02 = 365,
	HotbarCommon03 = 366,
	HotbarCommon04 = 367,
	HotbarCommon05 = 368,
	HotbarCommon06 = 369,
	HotbarCommon07 = 370,
	HotbarCommon08 = 371,
	HotbarCommon09 = 372,
	HotbarCommon10 = 373,
	HotbarCrossCommon01 = 374,
	HotbarCrossCommon02 = 375,
	HotbarCrossCommon03 = 376,
	HotbarCrossCommon04 = 377,
	HotbarCrossCommon05 = 378,
	HotbarCrossCommon06 = 379,
	HotbarCrossCommon07 = 380,
	HotbarCrossCommon08 = 381,
	HotbarCrossHelpDisp = 382,
	HotbarCrossOperation = 383,
	HotbarCrossDisp = 384,
	HotbarCrossLock = 385,
	HotbarCrossUsePadGuide = 388,
	HotbarCrossActiveSet = 389,
	HotbarCrossActiveSetPvP = 390,
	HotbarCrossSetChangeCustomIsAuto = 391,
	HotbarCrossSetChangeCustom = 393,
	HotbarCrossSetChangeCustomSet1 = 394,
	HotbarCrossSetChangeCustomSet2 = 395,
	HotbarCrossSetChangeCustomSet3 = 396,
	HotbarCrossSetChangeCustomSet4 = 397,
	HotbarCrossSetChangeCustomSet5 = 398,
	HotbarCrossSetChangeCustomSet6 = 399,
	HotbarCrossSetChangeCustomSet7 = 400,
	HotbarCrossSetChangeCustomSet8 = 401,
	HotbarCrossSetChangeCustomIsSword = 402,
	HotbarCrossSetChangeCustomIsSwordSet1 = 403,
	HotbarCrossSetChangeCustomIsSwordSet2 = 404,
	HotbarCrossSetChangeCustomIsSwordSet3 = 405,
	HotbarCrossSetChangeCustomIsSwordSet4 = 406,
	HotbarCrossSetChangeCustomIsSwordSet5 = 407,
	HotbarCrossSetChangeCustomIsSwordSet6 = 408,
	HotbarCrossSetChangeCustomIsSwordSet7 = 409,
	HotbarCrossSetChangeCustomIsSwordSet8 = 410,
	HotbarCrossAdvancedSetting = 411,
	HotbarCrossAdvancedSettingLeft = 412,
	HotbarCrossAdvancedSettingRight = 413,
	HotbarCrossSetPvpModeActive = 414,
	HotbarCrossSetChangeCustomPvp = 415,
	HotbarCrossSetChangeCustomIsAutoPvp = 416,
	HotbarCrossSetChangeCustomSet1Pvp = 417,
	HotbarCrossSetChangeCustomSet2Pvp = 418,
	HotbarCrossSetChangeCustomSet3Pvp = 419,
	HotbarCrossSetChangeCustomSet4Pvp = 420,
	HotbarCrossSetChangeCustomSet5Pvp = 421,
	HotbarCrossSetChangeCustomSet6Pvp = 422,
	HotbarCrossSetChangeCustomSet7Pvp = 423,
	HotbarCrossSetChangeCustomSet8Pvp = 424,
	HotbarCrossSetChangeCustomIsSwordPvp = 425,
	HotbarCrossSetChangeCustomIsSwordSet1Pvp = 426,
	HotbarCrossSetChangeCustomIsSwordSet2Pvp = 427,
	HotbarCrossSetChangeCustomIsSwordSet3Pvp = 428,
	HotbarCrossSetChangeCustomIsSwordSet4Pvp = 429,
	HotbarCrossSetChangeCustomIsSwordSet5Pvp = 430,
	HotbarCrossSetChangeCustomIsSwordSet6Pvp = 431,
	HotbarCrossSetChangeCustomIsSwordSet7Pvp = 432,
	HotbarCrossSetChangeCustomIsSwordSet8Pvp = 433,
	HotbarCrossAdvancedSettingPvp = 434,
	HotbarCrossAdvancedSettingLeftPvp = 435,
	HotbarCrossAdvancedSettingRightPvp = 436,
	HotbarWXHBEnable = 437,
	HotbarWXHBSetLeft = 438,
	HotbarWXHBSetRight = 439,
	HotbarWXHBEnablePvP = 440,
	HotbarWXHBSetLeftPvP = 441,
	HotbarWXHBSetRightPvP = 442,
	HotbarWXHB8Button = 443,
	HotbarWXHB8ButtonPvP = 444,
	HotbarWXHBSetInputTime = 445,
	HotbarWXHBDisplay = 446,
	HotbarWXHBFreeLayout = 447,
	HotbarXHBActiveTransmissionAlpha = 448,
	HotbarXHBAlphaDefault = 449,
	HotbarXHBAlphaActiveSet = 450,
	HotbarXHBAlphaInactiveSet = 451,
	HotbarWXHBInputOnce = 452,
	IdlingCameraSwitchType = 453,
	PlateType = 454,
	PlateDispHPBar = 455,
	PlateDisableMaxHPBar = 456,
	NamePlateHpSizeType = 457,
	NamePlateColorSelf = 458,
	NamePlateEdgeSelf = 459,
	NamePlateDispTypeSelf = 460,
	NamePlateNameTypeSelf = 461,
	NamePlateHpTypeSelf = 462,
	NamePlateColorSelfBuddy = 463,
	NamePlateEdgeSelfBuddy = 464,
	NamePlateDispTypeSelfBuddy = 465,
	NamePlateHpTypeSelfBuddy = 466,
	NamePlateColorSelfPet = 467,
	NamePlateEdgeSelfPet = 468,
	NamePlateDispTypeSelfPet = 469,
	NamePlateHpTypeSelfPet = 470,
	NamePlateColorParty = 471,
	NamePlateEdgeParty = 472,
	NamePlateDispTypeParty = 473,
	NamePlateNameTypeParty = 474,
	NamePlateHpTypeParty = 475,
	NamePlateDispTypePartyPet = 476,
	NamePlateHpTypePartyPet = 477,
	NamePlateDispTypePartyBuddy = 478,
	NamePlateHpTypePartyBuddy = 479,
	NamePlateColorAlliance = 480,
	NamePlateEdgeAlliance = 481,
	NamePlateDispTypeAlliance = 482,
	NamePlateNameTypeAlliance = 483,
	NamePlateHpTypeAlliance = 484,
	NamePlateDispTypeAlliancePet = 485,
	NamePlateHpTypeAlliancePet = 486,
	NamePlateColorOther = 487,
	NamePlateEdgeOther = 488,
	NamePlateDispTypeOther = 489,
	NamePlateNameTypeOther = 490,
	NamePlateHpTypeOther = 491,
	NamePlateDispTypeOtherPet = 492,
	NamePlateHpTypeOtherPet = 493,
	NamePlateDispTypeOtherBuddy = 494,
	NamePlateHpTypeOtherBuddy = 495,
	NamePlateColorUnengagedEnemy = 496,
	NamePlateEdgeUnengagedEnemy = 497,
	NamePlateDispTypeUnengagedEnemy = 498,
	NamePlateHpTypeUnengagedEmemy = 499,
	NamePlateColorEngagedEnemy = 500,
	NamePlateEdgeEngagedEnemy = 501,
	NamePlateDispTypeEngagedEnemy = 502,
	NamePlateHpTypeEngagedEmemy = 503,
	NamePlateColorClaimedEnemy = 504,
	NamePlateEdgeClaimedEnemy = 505,
	NamePlateDispTypeClaimedEnemy = 506,
	NamePlateHpTypeClaimedEmemy = 507,
	NamePlateColorUnclaimedEnemy = 508,
	NamePlateEdgeUnclaimedEnemy = 509,
	NamePlateDispTypeUnclaimedEnemy = 510,
	NamePlateHpTypeUnclaimedEmemy = 511,
	NamePlateColorNpc = 512,
	NamePlateEdgeNpc = 513,
	NamePlateDispTypeNpc = 514,
	NamePlateHpTypeNpc = 515,
	NamePlateColorObject = 516,
	NamePlateEdgeObject = 517,
	NamePlateDispTypeObject = 518,
	NamePlateHpTypeObject = 519,
	NamePlateColorMinion = 520,
	NamePlateEdgeMinion = 521,
	NamePlateDispTypeMinion = 522,
	NamePlateColorOtherBuddy = 523,
	NamePlateEdgeOtherBuddy = 524,
	NamePlateColorOtherPet = 525,
	NamePlateEdgeOtherPet = 526,
	NamePlateNameTitleTypeSelf = 527,
	NamePlateNameTitleTypeParty = 528,
	NamePlateNameTitleTypeAlliance = 529,
	NamePlateNameTitleTypeOther = 530,
	NamePlateNameTitleTypeFriend = 531,
	NamePlateColorFriend = 532,
	NamePlateColorFriendEdge = 533,
	NamePlateDispTypeFriend = 534,
	NamePlateNameTypeFriend = 535,
	NamePlateHpTypeFriend = 536,
	NamePlateDispTypeFriendPet = 537,
	NamePlateHpTypeFriendPet = 538,
	NamePlateDispTypeFriendBuddy = 539,
	NamePlateHpTypeFriendBuddy = 540,
	NamePlateColorLim = 541,
	NamePlateColorLimEdge = 542,
	NamePlateColorGri = 543,
	NamePlateColorGriEdge = 544,
	NamePlateColorUld = 545,
	NamePlateColorUldEdge = 546,
	NamePlateColorHousingFurniture = 547,
	NamePlateColorHousingFurnitureEdge = 548,
	NamePlateDispTypeHousingFurniture = 549,
	NamePlateColorHousingField = 550,
	NamePlateColorHousingFieldEdge = 551,
	NamePlateDispTypeHousingField = 552,
	NamePlateNameTypePvPEnemy = 553,
	NamePlateDispTypeFeast = 554,
	NamePlateNameTypeFeast = 555,
	NamePlateHpTypeFeast = 556,
	NamePlateDispTypeFeastPet = 557,
	NamePlateHpTypeFeastPet = 558,
	NamePlateNameTitleTypeFeast = 559,
	NamePlateDispSize = 560,
	ActiveInfo = 561,
	PartyList = 562,
	PartyListStatus = 563,
	PartyListStatusTimer = 565,
	EnemyList = 566,
	TargetInfo = 567,
	Gil = 568,
	DTR = 569,
	PlayerInfo = 571,
	NaviMap = 572,
	Help = 573,
	CrossMainHelp = 575,
	HousingLocatePreview = 577,
	Log = 578,
	LogTell = 579,
	LogFontSize = 581,
	LogTabName2 = 582,
	LogTabName3 = 583,
	LogTabFilter0 = 584,
	LogTabFilter1 = 585,
	LogTabFilter2 = 586,
	LogTabFilter3 = 587,
	LogChatFilter = 588,
	LogEnableErrMsgLv1 = 589,
	LogNameType = 591,
	LogTimeDisp = 592,
	LogTimeSettingType = 593,
	LogTimeDispType = 594,
	IsLogTell = 595,
	IsLogParty = 596,
	LogParty = 597,
	IsLogAlliance = 598,
	LogAlliance = 599,
	IsLogFc = 600,
	LogFc = 601,
	IsLogPvpTeam = 602,
	LogPvpTeam = 603,
	IsLogLs1 = 604,
	LogLs1 = 605,
	IsLogLs2 = 606,
	LogLs2 = 607,
	IsLogLs3 = 608,
	LogLs3 = 609,
	IsLogLs4 = 610,
	LogLs4 = 611,
	IsLogLs5 = 612,
	LogLs5 = 613,
	IsLogLs6 = 614,
	LogLs6 = 615,
	IsLogLs7 = 616,
	LogLs7 = 617,
	IsLogLs8 = 618,
	LogLs8 = 619,
	IsLogBeginner = 620,
	LogBeginner = 621,
	IsLogCwls = 622,
	IsLogCwls2 = 623,
	IsLogCwls3 = 624,
	IsLogCwls4 = 625,
	IsLogCwls5 = 626,
	IsLogCwls6 = 627,
	IsLogCwls7 = 628,
	IsLogCwls8 = 629,
	LogCwls = 630,
	LogCwls2 = 631,
	LogCwls3 = 632,
	LogCwls4 = 633,
	LogCwls5 = 634,
	LogCwls6 = 635,
	LogCwls7 = 636,
	LogCwls8 = 637,
	LogRecastActionErrDisp = 638,
	LogPermeationRate = 639,
	LogFontSizeForm = 640,
	LogItemLinkEnableType = 641,
	LogFontSizeLog2 = 642,
	LogTimeDispLog2 = 643,
	LogPermeationRateLog2 = 644,
	LogFontSizeLog3 = 645,
	LogTimeDispLog3 = 646,
	LogPermeationRateLog3 = 647,
	LogFontSizeLog4 = 648,
	LogTimeDispLog4 = 649,
	LogPermeationRateLog4 = 650,
	LogFlyingHeightMaxErrDisp = 651,
	LogCrossWorldName = 652,
	LogDragResize = 653,
	ChatType = 654,
	ShopSell = 655,
	ColorSay = 656,
	ColorShout = 657,
	ColorTell = 658,
	ColorParty = 659,
	ColorAlliance = 660,
	ColorLS1 = 661,
	ColorLS2 = 662,
	ColorLS3 = 663,
	ColorLS4 = 664,
	ColorLS5 = 665,
	ColorLS6 = 666,
	ColorLS7 = 667,
	ColorLS8 = 668,
	ColorFCompany = 669,
	ColorPvPGroup = 670,
	ColorPvPGroupAnnounce = 671,
	ColorBeginner = 672,
	ColorEmoteUser = 673,
	ColorEmote = 674,
	ColorYell = 675,
	ColorBeginnerAnnounce = 677,
	ColorCWLS = 678,
	ColorCWLS2 = 679,
	ColorCWLS3 = 680,
	ColorCWLS4 = 681,
	ColorCWLS5 = 682,
	ColorCWLS6 = 683,
	ColorCWLS7 = 684,
	ColorCWLS8 = 685,
	ColorAttackSuccess = 686,
	ColorAttackFailure = 687,
	ColorAction = 688,
	ColorItem = 689,
	ColorCureGive = 690,
	ColorBuffGive = 691,
	ColorDebuffGive = 692,
	ColorEcho = 693,
	ColorSysMsg = 694,
	ColorFCAnnounce = 695,
	ColorSysBattle = 696,
	ColorSysGathering = 697,
	ColorSysErr = 698,
	ColorNpcSay = 699,
	ColorItemNotice = 700,
	ColorGrowup = 701,
	ColorLoot = 702,
	ColorCraft = 703,
	ColorGathering = 704,
	ShopConfirm = 706,
	ShopConfirmMateria = 707,
	ShopConfirmExRare = 708,
	ShopConfirmSpiritBondMax = 709,
	ItemSortItemCategory = 710,
	ItemSortEquipLevel = 711,
	ItemSortItemLevel = 712,
	ItemSortItemStack = 713,
	ItemSortTidyingType = 714,
	ItemNoArmoryMaskOff = 715,
	InfoSettingDispWorldNameType = 728,
	TargetNamePlateNameType = 730,
	FocusTargetNamePlateNameType = 733,
	ItemDetailTemporarilySwitch = 735,
	ItemDetailTemporarilySwitchKey = 736,
	ItemDetailTemporarilyHide = 737,
	ItemDetailTemporarilyHideKey = 738,
	ToolTipDispSize = 748,
	RecommendLoginDisp = 749,
	RecommendAreaChangeDisp = 750,
	PlayGuideLoginDisp = 751,
	PlayGuideAreaChangeDisp = 752,
	MapPadOperationYReverse = 755,
	MapPadOperationXReverse = 756,
	MapDispSize = 758,
	FlyTextDispSize = 759,
	PopUpTextDispSize = 761,
	DetailDispDelayType = 762,
	PartyListSortTypeTank = 763,
	PartyListSortTypeHealer = 764,
	PartyListSortTypeDps = 765,
	PartyListSortTypeOther = 766,
	RatioHpDisp = 767,
	BuffDispType = 768,
	ContentsFinderListSortType = 771,
	ContentsFinderSupplyEnable = 772,
	EnemyListCastbarEnable = 778,
	AchievementAppealLoginDisp = 779,
	ContentsFinderUseLangTypeJA = 780,
	ContentsFinderUseLangTypeEN = 781,
	ContentsFinderUseLangTypeDE = 782,
	ContentsFinderUseLangTypeFR = 783,
	ItemInventryWindowSizeType = 791,
	ItemInventryRetainerWindowSizeType = 792,
	BattleTalkShowFace = 798,
	BannerContentsDispType = 799,
	BannerContentsNotice = 800,
	MipDispType = 801,
	BannerContentsOrderType = 802,
	EmoteTextType = 803,
	IsEmoteSe = 804,
	EmoteSeType = 805,
	PartyFinderNewArrivalDisp = 806,
	GPoseTargetFilterNPCLookAt = 807,
	GPoseMotionFilterAction = 808,
	LsListSortPriority = 809,
	FriendListSortPriority = 810,
	FriendListFilterType = 811,
	FriendListSortType = 812,
	LetterListFilterType = 813,
	LetterListSortType = 814,
	ContentsReplayEnable = 816,
	MouseWheelOperationUp = 817,
	MouseWheelOperationDown = 818,
	MouseWheelOperationCtrlUp = 819,
	MouseWheelOperationCtrlDown = 820,
	MouseWheelOperationAltUp = 821,
	MouseWheelOperationAltDown = 822,
	MouseWheelOperationShiftUp = 823,
	MouseWheelOperationShiftDown = 824,
	TelepoTicketUseType = 825,
	TelepoTicketGilSetting = 826,
	PvPFrontlinesGCFree = 831,

	// UiControl Config
	// UiControl - Charcter Settings
	AutoChangePointOfView = 172,
	KeyboardCameraInterpolationType = 173,
	KeyboardCameraVerticalInterpolation = 174,
	TiltOffset = 175,
	KeyboardSpeed = 176,
	PadSpeed = 177,
	PadFpsXReverse = 179,
	PadFpsYReverse = 180,
	PadTpsXReverse = 181,
	PadTpsYReverse = 182,
	MouseFpsXReverse = 183,
	MouseFpsYReverse = 184,
	MouseTpsXReverse = 185,
	MouseTpsYReverse = 186,
	MouseCharaViewRotYReverse = 187,
	MouseCharaViewRotXReverse = 188,
	MouseCharaViewMoveYReverse = 189,
	MouseCharaViewMoveXReverse = 190,
	PADCharaViewRotYReverse = 191,
	PADCharaViewRotXReverse = 192,
	PADCharaViewMoveYReverse = 193,
	PADCharaViewMoveXReverse = 194,
	FlyingControlType = 208,
	FlyingLegacyAutorun = 209,
	// UiControl - Target Settings
	AutoFaceTargetOnAction = 211,
	SelfClick = 212,
	NoTargetClickCancel = 213,
	AutoTarget = 214,
	TargetTypeSelect = 215,
	AutoLockOn = 216,
	CircleBattleModeAutoChange = 218,
	CircleIsCustom = 219,
	CircleSwordDrawnIsActive = 220,
	CircleSwordDrawnNonPartyPc = 221,
	CircleSwordDrawnParty = 222,
	CircleSwordDrawnEnemy = 223,
	CircleSwordDrawnAggro = 224,
	CircleSwordDrawnNpcOrObject = 225,
	CircleSwordDrawnMinion = 226,
	CircleSwordDrawnDutyEnemy = 227,
	CircleSwordDrawnPet = 228,
	CircleSwordDrawnAlliance = 229,
	CircleSwordDrawnMark = 230,
	CircleSheathedIsActive = 231,
	CircleSheathedNonPartyPc = 232,
	CircleSheathedParty = 233,
	CircleSheathedEnemy = 234,
	CircleSheathedAggro = 235,
	CircleSheathedNpcOrObject = 236,
	CircleSheathedMinion = 237,
	CircleSheathedDutyEnemy = 238,
	CircleSheathedPet = 239,
	CircleSheathedAlliance = 240,
	CircleSheathedMark = 241,
	CircleClickIsActive = 242,
	CircleClickNonPartyPc = 243,
	CircleClickParty = 244,
	CircleClickEnemy = 245,
	CircleClickAggro = 246,
	CircleClickNpcOrObject = 247,
	CircleClickMinion = 248,
	CircleClickDutyEnemy = 249,
	CircleClickPet = 250,
	CircleClickAlliance = 251,
	CircleClickMark = 252,
	CircleXButtonIsActive = 253,
	CircleXButtonNonPartyPc = 254,
	CircleXButtonParty = 255,
	CircleXButtonEnemy = 256,
	CircleXButtonAggro = 257,
	CircleXButtonNpcOrObject = 258,
	CircleXButtonMinion = 259,
	CircleXButtonDutyEnemy = 260,
	CircleXButtonPet = 261,
	CircleXButtonAlliance = 262,
	CircleXButtonMark = 263,
	CircleYButtonIsActive = 264,
	CircleYButtonNonPartyPc = 265,
	CircleYButtonParty = 266,
	CircleYButtonEnemy = 267,
	CircleYButtonAggro = 268,
	CircleYButtonNpcOrObject = 269,
	CircleYButtonMinion = 270,
	CircleYButtonDutyEnemy = 271,
	CircleYButtonPet = 272,
	CircleYButtonAlliance = 273,
	CircleYButtonMark = 274,
	CircleBButtonIsActive = 275,
	CircleBButtonNonPartyPc = 276,
	CircleBButtonParty = 277,
	CircleBButtonEnemy = 278,
	CircleBButtonAggro = 279,
	CircleBButtonNpcOrObject = 280,
	CircleBButtonMinion = 281,
	CircleBButtonDutyEnemy = 282,
	CircleBButtonPet = 283,
	CircleBButtonAlliance = 284,
	CircleBButtonMark = 285,
	CircleAButtonIsActive = 286,
	CircleAButtonNonPartyPc = 287,
	CircleAButtonParty = 288,
	CircleAButtonEnemy = 289,
	CircleAButtonAggro = 290,
	CircleAButtonNpcOrObject = 291,
	CircleAButtonMinion = 292,
	CircleAButtonDutyEnemy = 293,
	CircleAButtonPet = 294,
	CircleAButtonAlliance = 295,
	CircleAButtonMark = 296,
	GroundTargetType = 297,
	GroundTargetCursorSpeed = 298,
	TargetCircleType = 309,
	TargetLineType = 310,
	LinkLineType = 311,
	ObjectBorderingType = 312,
	MoveMode = 320,
	HotbarDisp = 344,
	HotbarEmptyVisible = 346,
	HotbarNoneSlotDisp01 = 350,
	HotbarNoneSlotDisp02 = 351,
	HotbarNoneSlotDisp03 = 352,
	HotbarNoneSlotDisp04 = 353,
	HotbarNoneSlotDisp05 = 354,
	HotbarNoneSlotDisp06 = 355,
	HotbarNoneSlotDisp07 = 356,
	HotbarNoneSlotDisp08 = 357,
	HotbarNoneSlotDisp09 = 358,
	HotbarNoneSlotDisp10 = 359,
	HotbarNoneSlotDispEX = 360,
	ExHotbarSetting = 361,
	HotbarExHotbarUseSetting = 363,
	HotbarCrossUseEx = 386,
	HotbarCrossUseExDirection = 387,
	HotbarCrossDispType = 392,
	PartyListSoloOff = 564,
	HowTo = 574,
	HousingFurnitureBindConfirm = 576,
	DirectChat = 590,
	CharaParamDisp = 716,
	LimitBreakGaugeDisp = 717,
	ScenarioTreeDisp = 718,
	ScenarioTreeCompleteDisp = 719,
	HotbarCrossDispAlways = 720,
	ExpDisp = 721,
	InventryStatusDisp = 722,
	DutyListDisp = 723,
	NaviMapDisp = 724,
	GilStatusDisp = 725,
	InfoSettingDisp = 726,
	InfoSettingDispType = 727,
	TargetInfoDisp = 729,
	EnemyListDisp = 731,
	FocusTargetDisp = 732,
	ItemDetailDisp = 734,
	ActionDetailDisp = 739,
	DetailTrackingType = 740,
	ToolTipDisp = 741,
	MapPermeationRate = 742,
	MapOperationType = 743,
	PartyListDisp = 744,
	PartyListNameType = 745,
	FlyTextDisp = 746,
	MapPermeationMode = 747,
	AllianceList1Disp = 753,
	AllianceList2Disp = 754,
	TargetInfoSelfBuff = 757,
	PopUpTextDisp = 760,
	ContentsInfoDisp = 769,
	DutyListHideWhenCntInfoDisp = 770,
	DutyListNumDisp = 773,
	InInstanceContentDutyListDisp = 774,
	InPublicContentDutyListDisp = 775,
	ContentsInfoJoiningRequestDisp = 776,
	ContentsInfoJoiningRequestSituationDisp = 777,
	HotbarDispSetNum = 784,
	HotbarDispSetChangeType = 785,
	HotbarDispSetDragType = 786,
	MainCommandType = 787,
	MainCommandDisp = 788,
	MainCommandDragShortcut = 789,
	HotbarDispLookNum = 790
}
