//
// Copyright (C) 2015 crosire & contributors
// License: https://github.com/crosire/scripthookvdotnet#license
//

namespace RDR2
{
	public enum Control
	{
		NextCamera,
		LookLeftRight,
		LookUpDown,
		LookUpOnly,
		LookDownOnly,
		LookLeftOnly,
		LookRightOnly,
		CinematicSlowMo,
		FlyUpDown,
		FlyLeftRight,
		ScriptedFlyZUp,
		ScriptedFlyZDown,
		WeaponWheelUpDown,
		WeaponWheelLeftRight,
		WeaponWheelNext,
		WeaponWheelPrev,
		SelectNextWeapon,
		SelectPrevWeapon,
		SkipCutscene,
		CharacterWheel,
		MultiplayerInfo,
		Sprint,
		Jump,
		Enter,
		Attack,
		Aim,
		LookBehind,
		Phone,
		SpecialAbility,
		SpecialAbilitySecondary,
		MoveLeftRight,
		MoveUpDown,
		MoveUpOnly,
		MoveDownOnly,
		MoveLeftOnly,
		MoveRightOnly,
		Duck,
		SelectWeapon,
		Pickup,
		SniperZoom,
		SniperZoomInOnly,
		SniperZoomOutOnly,
		SniperZoomInSecondary,
		SniperZoomOutSecondary,
		Cover,
		Reload,
		Talk,
		Detonate,
		HUDSpecial,
		Arrest,
		AccurateAim,
		Context,
		ContextSecondary,
		WeaponSpecial,
		WeaponSpecial2,
		Dive,
		DropWeapon,
		DropAmmo,
		ThrowGrenade,
		VehicleMoveLeftRight,
		VehicleMoveUpDown,
		VehicleMoveUpOnly,
		VehicleMoveDownOnly,
		VehicleMoveLeftOnly,
		VehicleMoveRightOnly,
		VehicleSpecial,
		VehicleGunLeftRight,
		VehicleGunUpDown,
		VehicleAim,
		VehicleAttack,
		VehicleAttack2,
		VehicleAccelerate,
		VehicleBrake,
		VehicleDuck,
		VehicleHeadlight,
		VehicleExit,
		VehicleHandbrake,
		VehicleHotwireLeft,
		VehicleHotwireRight,
		VehicleLookBehind,
		VehicleCinCam,
		VehicleNextRadio,
		VehiclePrevRadio,
		VehicleNextRadioTrack,
		VehiclePrevRadioTrack,
		VehicleRadioWheel,
		VehicleHorn,
		VehicleFlyThrottleUp,
		VehicleFlyThrottleDown,
		VehicleFlyYawLeft,
		VehicleFlyYawRight,
		VehiclePassengerAim,
		VehiclePassengerAttack,
		VehicleSpecialAbilityFranklin,
		VehicleStuntUpDown,
		VehicleCinematicUpDown,
		VehicleCinematicUpOnly,
		VehicleCinematicDownOnly,
		VehicleCinematicLeftRight,
		VehicleSelectNextWeapon,
		VehicleSelectPrevWeapon,
		VehicleRoof,
		VehicleJump,
		VehicleGrapplingHook,
		VehicleShuffle,
		VehicleDropProjectile,
		VehicleMouseControlOverride,
		VehicleFlyRollLeftRight,
		VehicleFlyRollLeftOnly,
		VehicleFlyRollRightOnly,
		VehicleFlyPitchUpDown,
		VehicleFlyPitchUpOnly,
		VehicleFlyPitchDownOnly,
		VehicleFlyUnderCarriage,
		VehicleFlyAttack,
		VehicleFlySelectNextWeapon,
		VehicleFlySelectPrevWeapon,
		VehicleFlySelectTargetLeft,
		VehicleFlySelectTargetRight,
		VehicleFlyVerticalFlightMode,
		VehicleFlyDuck,
		VehicleFlyAttackCamera,
		VehicleFlyMouseControlOverride,
		VehicleSubTurnLeftRight,
		VehicleSubTurnLeftOnly,
		VehicleSubTurnRightOnly,
		VehicleSubPitchUpDown,
		VehicleSubPitchUpOnly,
		VehicleSubPitchDownOnly,
		VehicleSubThrottleUp,
		VehicleSubThrottleDown,
		VehicleSubAscend,
		VehicleSubDescend,
		VehicleSubTurnHardLeft,
		VehicleSubTurnHardRight,
		VehicleSubMouseControlOverride,
		VehiclePushbikePedal,
		VehiclePushbikeSprint,
		VehiclePushbikeFrontBrake,
		VehiclePushbikeRearBrake,
		MeleeAttackLight,
		MeleeAttackHeavy,
		MeleeAttackAlternate,
		MeleeBlock,
		ParachuteDeploy,
		ParachuteDetach,
		ParachuteTurnLeftRight,
		ParachuteTurnLeftOnly,
		ParachuteTurnRightOnly,
		ParachutePitchUpDown,
		ParachutePitchUpOnly,
		ParachutePitchDownOnly,
		ParachuteBrakeLeft,
		ParachuteBrakeRight,
		ParachuteSmoke,
		ParachutePrecisionLanding,
		Map,
		SelectWeaponUnarmed,
		SelectWeaponMelee,
		SelectWeaponHandgun,
		SelectWeaponShotgun,
		SelectWeaponSmg,
		SelectWeaponAutoRifle,
		SelectWeaponSniper,
		SelectWeaponHeavy,
		SelectWeaponSpecial,
		SelectCharacterMichael,
		SelectCharacterFranklin,
		SelectCharacterTrevor,
		SelectCharacterMultiplayer,
		SaveReplayClip,
		SpecialAbilityPC,
		PhoneUp,
		PhoneDown,
		PhoneLeft,
		PhoneRight,
		PhoneSelect,
		PhoneCancel,
		PhoneOption,
		PhoneExtraOption,
		PhoneScrollForward,
		PhoneScrollBackward,
		PhoneCameraFocusLock,
		PhoneCameraGrid,
		PhoneCameraSelfie,
		PhoneCameraDOF,
		PhoneCameraExpression,
		FrontendDown,
		FrontendUp,
		FrontendLeft,
		FrontendRight,
		FrontendRdown,
		FrontendRup,
		FrontendRleft,
		FrontendRright,
		FrontendAxisX,
		FrontendAxisY,
		FrontendRightAxisX,
		FrontendRightAxisY,
		FrontendPause,
		FrontendPauseAlternate,
		FrontendAccept,
		FrontendCancel,
		FrontendX,
		FrontendY,
		FrontendLb,
		FrontendRb,
		FrontendLt,
		FrontendRt,
		FrontendLs,
		FrontendRs,
		FrontendLeaderboard,
		FrontendSocialClub,
		FrontendSocialClubSecondary,
		FrontendDelete,
		FrontendEndscreenAccept,
		FrontendEndscreenExpand,
		FrontendSelect,
		ScriptLeftAxisX,
		ScriptLeftAxisY,
		ScriptRightAxisX,
		ScriptRightAxisY,
		ScriptRUp,
		ScriptRDown,
		ScriptRLeft,
		ScriptRRight,
		ScriptLB,
		ScriptRB,
		ScriptLT,
		ScriptRT,
		ScriptLS,
		ScriptRS,
		ScriptPadUp,
		ScriptPadDown,
		ScriptPadLeft,
		ScriptPadRight,
		ScriptSelect,
		CursorAccept,
		CursorCancel,
		CursorX,
		CursorY,
		CursorScrollUp,
		CursorScrollDown,
		EnterCheatCode,
		InteractionMenu,
		MpTextChatAll,
		MpTextChatTeam,
		MpTextChatFriends,
		MpTextChatCrew,
		PushToTalk,
		CreatorLS,
		CreatorRS,
		CreatorLT,
		CreatorRT,
		CreatorMenuToggle,
		CreatorAccept,
		CreatorDelete,
		Attack2,
		RappelJump,
		RappelLongJump,
		RappelSmashWindow,
		PrevWeapon,
		NextWeapon,
		MeleeAttack1,
		MeleeAttack2,
		Whistle,
		MoveLeft,
		MoveRight,
		MoveUp,
		MoveDown,
		LookLeft,
		LookRight,
		LookUp,
		LookDown,
		SniperZoomIn,
		SniperZoomOut,
		SniperZoomInAlternate,
		SniperZoomOutAlternate,
		VehicleMoveLeft,
		VehicleMoveRight,
		VehicleMoveUp,
		VehicleMoveDown,
		VehicleGunLeft,
		VehicleGunRight,
		VehicleGunUp,
		VehicleGunDown,
		VehicleLookLeft,
		VehicleLookRight,
		ReplayStartStopRecording,
		ReplayStartStopRecordingSecondary,
		ScaledLookLeftRight,
		ScaledLookUpDown,
		ScaledLookUpOnly,
		ScaledLookDownOnly,
		ScaledLookLeftOnly,
		ScaledLookRightOnly,
		ReplayMarkerDelete,
		ReplayClipDelete,
		ReplayPause,
		ReplayRewind,
		ReplayFfwd,
		ReplayNewmarker,
		ReplayRecord,
		ReplayScreenshot,
		ReplayHidehud,
		ReplayStartpoint,
		ReplayEndpoint,
		ReplayAdvance,
		ReplayBack,
		ReplayTools,
		ReplayRestart,
		ReplayShowhotkey,
		ReplayCycleMarkerLeft,
		ReplayCycleMarkerRight,
		ReplayFOVIncrease,
		ReplayFOVDecrease,
		ReplayCameraUp,
		ReplayCameraDown,
		ReplaySave,
		ReplayToggletime,
		ReplayToggletips,
		ReplayPreview,
		ReplayToggleTimeline,
		ReplayTimelinePickupClip,
		ReplayTimelineDuplicateClip,
		ReplayTimelinePlaceClip,
		ReplayCtrl,
		ReplayTimelineSave,
		ReplayPreviewAudio,
		VehicleDriveLook,
		VehicleDriveLook2,
		VehicleFlyAttack2,
		RadioWheelUpDown,
		RadioWheelLeftRight,
		VehicleSlowMoUpDown,
		VehicleSlowMoUpOnly,
		VehicleSlowMoDownOnly,
		MapPointOfInterest,
		ReplaySnapmaticPhoto,
		VehicleCarJump,
		VehicleRocketBoost,
		VehicleParachute,
		VehicleBikeWings,
		VehicleFlyBombBay,
		VehicleFlyCounter,
		VehicleFlyTransform,
	}
}
