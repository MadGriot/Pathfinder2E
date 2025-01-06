

namespace Pathfinder2E.Mechanics
{
    public static class SetClass
    {
        public static void Set(CharacterSheet character, Class @class)
        {
            switch(@class)
            {
                case Class.Alchemist:
                    character.MaxHP = 8 + character.ConstitutionModifier;
                    character.CurrentHP = character.MaxHP;
                    character.Intelligence += 2;
                    character.Proficiencies = new Proficiencies
                    {
                        Perception = 1,
                        Fortitude = 2,
                        Reflex = 2,
                        Will = 1,
                        Simple_Weapons = 1,
                        Alchemical_bombs = 1,
                        Unarmed_Attacks = 1,
                        Light_Armor = 1,
                        Medium_Armor = 1,
                        Unarmored_Defence = 1,
                    };
                    character.ClassDCs = new ClassDCs { Alchemist = 1 };
                    break;
                case Class.Barbarian:
                    character.MaxHP = 12 + character.ConstitutionModifier;
                    character.CurrentHP = character.MaxHP;
                    character.Strength += 2;
                    character.Proficiencies = new Proficiencies
                    {
                        Perception = 2,
                        Fortitude = 2,
                        Reflex = 1,
                        Will = 2,
                        Simple_Weapons = 1,
                        Martial_Weapons = 1,
                        Unarmed_Attacks = 1,
                        Light_Armor = 1,
                        Medium_Armor = 1,
                        Unarmored_Defence = 1,
                    };
                    character.ClassDCs = new ClassDCs { Barbarian = 1 };
                    break;
                case Class.Bard:
                    character.MaxHP = 8 + character.ConstitutionModifier;
                    character.CurrentHP = character.MaxHP;
                    character.Charisma += 2;
                    character.Proficiencies = new Proficiencies
                    {
                        Perception = 2,
                        Fortitude = 1,
                        Reflex = 1,
                        Will = 2,
                        Simple_Weapons = 1,
                        Light_Armor = 1,
                        Unarmored_Defence = 1,
                        Occult_Spell_Attacks = 1,
                        Occult_Spell_DCs = 1,
                    };
                    break;
                case Class.Champion:
                    character.MaxHP = 10 + character.ConstitutionModifier;
                    character.CurrentHP = character.MaxHP;
                    character.FreeBoosts += 1;
                    Limiter.restrictedBoostReset();
                    Limiter.RestrictedBoostsLimit[0] = true;
                    Limiter.RestrictedBoostsLimit[1] = true;
                    character.Proficiencies = new Proficiencies
                    {
                        Perception = 1,
                        Fortitude = 2,
                        Reflex = 1,
                        Will = 2,
                        Simple_Weapons = 1,
                        Martial_Weapons = 1,
                        Unarmed_Attacks = 1,
                        Light_Armor = 1,
                        Medium_Armor = 1,
                        Heavy_Armor = 1,
                        Unarmored_Defence = 1,
                        Divine_Spell_Attacks = 1,
                        Divine_Spell_DC = 1,
                        
                    };
                    character.ClassDCs = new ClassDCs { Champion = 1 };
                    break;
                case Class.Cleric:
                    character.MaxHP = 8 + character.ConstitutionModifier;
                    character.CurrentHP = character.MaxHP;
                    character.Wisdom += 2;
                    character.Proficiencies = new Proficiencies
                    {
                        Perception = 1,
                        Fortitude = 1,
                        Reflex = 1,
                        Will = 2,
                        Simple_Weapons = 1,
                        //Needs Deity for weapon access, make sure to code it in.
                        Unarmed_Attacks= 1,
                        Unarmored_Defence= 1,
                        Divine_Spell_Attacks= 1,
                        Divine_Spell_DC= 1,
                    };
                    break;
                case Class.Druid:
                    character.MaxHP = 8 + character.ConstitutionModifier;
                    character.CurrentHP = character.MaxHP;
                    character.Wisdom += 2;
                    character.Proficiencies = new Proficiencies
                    {
                        Perception = 1,
                        Fortitude = 1,
                        Reflex = 1,
                        Will = 2,
                        Simple_Weapons = 1,
                        Unarmed_Attacks = 1,
                        Light_Armor = 1,
                        Medium_Armor = 1,
                        Unarmored_Defence = 1,
                        Primal_Spell_Attacks = 1,
                        Primal_Spell_DCs = 1,
                    };
                    break;
                case Class.Fighter:
                    character.MaxHP = 10 + character.ConstitutionModifier;
                    character.CurrentHP = character.MaxHP;
                    character.FreeBoosts += 1;
                    Limiter.restrictedBoostReset();
                    Limiter.RestrictedBoostsLimit[0] = true;
                    Limiter.RestrictedBoostsLimit[1] = true;
                    character.Proficiencies = new Proficiencies
                    {
                        Perception = 2,
                        Fortitude = 2,
                        Reflex = 2,
                        Will = 1,
                        Simple_Weapons = 2,
                        Martial_Weapons = 2,
                        Advanced_Weapons = 1,
                        Unarmed_Attacks = 1,
                        Light_Armor = 1,
                        Medium_Armor = 1,
                        Heavy_Armor = 1,
                        Unarmored_Defence = 1,
                    };
                    character.ClassDCs = new ClassDCs { Fighter = 1 };
                    break;
                case Class.Monk:
                    character.MaxHP = 10 + character.ConstitutionModifier;
                    character.CurrentHP = character.MaxHP;
                    character.FreeBoosts += 1;
                    Limiter.restrictedBoostReset();
                    Limiter.RestrictedBoostsLimit[0] = true;
                    Limiter.RestrictedBoostsLimit[1] = true;
                    character.Proficiencies = new Proficiencies
                    {
                        Perception = 1,
                        Fortitude = 2,
                        Reflex = 2,
                        Will = 2,
                        Simple_Weapons = 1,
                        Unarmed_Attacks = 1,
                        Unarmored_Defence = 2,
                    };
                    character.ClassDCs = new ClassDCs { Monk = 1 };
                    break;
                case Class.Ranger:
                    character.MaxHP = 10 + character.ConstitutionModifier;
                    character.CurrentHP = character.MaxHP;
                    character.FreeBoosts += 1;
                    Limiter.restrictedBoostReset();
                    Limiter.RestrictedBoostsLimit[0] = true;
                    Limiter.RestrictedBoostsLimit[1] = true;
                    character.Proficiencies = new Proficiencies
                    {
                        Perception = 2,
                        Fortitude = 2,
                        Reflex = 2,
                        Will = 1,
                        Simple_Weapons = 1,
                        Martial_Weapons = 1,
                        Unarmed_Attacks = 1,
                        Light_Armor = 1,
                        Medium_Armor = 1,
                        Unarmored_Defence = 1,
                    };
                    character.ClassDCs = new ClassDCs { Ranger = 1 };
                    break;
                case Class.Rogue:
                    character.MaxHP = 8 + character.ConstitutionModifier;
                    character.CurrentHP = character.MaxHP;
                    character.FreeBoosts += 1;
                    //code in Rogue racket.
                    character.Proficiencies = new Proficiencies
                    {
                        Perception = 2,
                        Fortitude = 1,
                        Reflex = 2,
                        Will = 2,
                        Simple_Weapons = 1,
                        Rapier = 1,
                        Sap = 1,
                        Shortbow = 1,
                        Shortsword = 1,
                        Unarmed_Attacks = 1,
                        Light_Armor = 1,
                        Unarmored_Defence = 1,
                    };
                    character.ClassDCs = new ClassDCs { Rogue = 1};
                    break;
                case Class.Sorcerer:
                    character.MaxHP = 6 + character.ConstitutionModifier;
                    character.CurrentHP = character.MaxHP;
                    character.Charisma += 2;
                    character.Proficiencies = new Proficiencies
                    {
                        Perception = 1,
                        Fortitude = 1,
                        Reflex = 1,
                        Will = 2,
                        Simple_Weapons = 1,
                        Unarmed_Attacks = 1,
                        Unarmored_Defence = 1,
                        //Code in Proficiencies based on boodline.
                    };
                    break;
                case Class.Wizard:
                    character.MaxHP = 6 + character.ConstitutionModifier;
                    character.CurrentHP = character.MaxHP;
                    character.Intelligence += 2;
                    character.Proficiencies = new Proficiencies
                    {
                        Perception = 1,
                        Fortitude = 1,
                        Reflex = 1,
                        Will = 2,
                        Club = 1,
                        Crossbow = 1,
                        Dagger = 1,
                        Heavy_Crossbow = 1,
                        Staff = 1,
                        Unarmed_Attacks = 1,
                        Unarmored_Defence = 1,
                        Arcane_Spell_Attacks = 1,
                        Arcane_Spell_DC = 1,
                    };
                    break;
            }
        }
    }
}
