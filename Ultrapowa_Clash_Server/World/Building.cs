namespace Ultrapowa_Clash_Server.World
{
    using FileHelpers;
    using System;

    [DelimitedRecord(","), IgnoreFirst(2)]
    internal class Building
    {
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public bool? AirTargets;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public bool? AltAirTargets;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public bool? AltAttackMode;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public int? AltAttackRange;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public int? AlternatePickNewTargetDelay;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public bool? AltGroundTargets;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public bool? AltMultiTargets;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public int? AltNumMultiTargets;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public int? AmmoCost;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public int? AmmoCount;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public string AmmoResource;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public string AOESpell;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public string AOESpellAlternate;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public string AppearEffect;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public string AttackEffect;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public string AttackEffect2;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public string AttackEffectLv2;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public string AttackEffectLv3;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public int? AttackRange;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public int? AttackSpeed;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public int? BoostCost;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public int? BuildCost;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public string BuildingClass;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public int? BuildingH;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public int? BuildingW;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public string BuildResource;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public int? BuildTimeD;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public int? BuildTimeH;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public int? BuildTimeM;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public bool? Bunker;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public bool? CanNotSellLast;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public int? Damage;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public int? DamageLv2;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public int? DamageLv3;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public int? DamageMulti;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public int? DamageRadius;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public string DefenderCharacter;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public int? DefenderCount;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public int? DefenderZ;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public string DestroyEffect;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public int? DestructionXP;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public string ExportName;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public string ExportNameBase;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public string ExportNameBaseNpc;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public string ExportNameBaseWar;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public string ExportNameBuildAnim;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public string ExportNameConstruction;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public string ExportNameDamaged;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public string ExportNameNpc;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public string ExportNameTriggered;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public bool? ForgesSpells;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public bool? GroundTargets;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public int? Height;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public string HeroType;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public bool? Hidden;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public string HitEffect;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public int? Hitpoints;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public int? HousingSpace;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public string Icon;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public bool? IncreasingDamage;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public string InfoTID;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public bool? IsHeroBarrack;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public string LoadAmmoEffect;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public bool? Locked;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public int? Lv2SwitchTime;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public int? Lv3SwitchTime;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public int? MaxStoredDarkElixir;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public int? MaxStoredElixir;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public int? MaxStoredGold;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public int? MaxStoredWarDarkElixir;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public int? MaxStoredWarElixir;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public int? MaxStoredWarGold;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public int? MinAttackRange;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public string Name;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public string NoAmmoEffect;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public string PickUpEffect;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public string PlacingEffect;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public string PreferredTarget;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public int? PreferredTargetDamageMod;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public bool? PreventsHealing;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public string ProducesResource;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public int? ProducesUnitsOfType;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public string Projectile;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public bool? PushBack;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public bool? RandomHitPosition;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public int? RegenTime;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public int? ResourceIconLimit;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public int? ResourceMax;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public int? ResourcePerHour;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public int? StrengthWeight;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public string SWF;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public string TID;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public string ToggleAttackModeEffect;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public int? TownHallLevel;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public string TransitionEffectLv2;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public string TransitionEffectLv3;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public int? TriggerRadius;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public int? UnitProduction;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public bool? UpgradesUnits;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public bool? WallCornerPieces;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public int? Width;
    }
}

