

namespace Pathfinder2E.Mechanics
{
    public static class SetClass
    {
        public static void Set(Character character, Class @class)
        {
            switch(@class)
            {
                case Class.Alchemist:
                    character.maxHP = 8 + character.constitution_modifier;
                    character.currentHP = character.maxHP;
                    character.intelligence += 2;
                    character.proficiencies = new Proficiencies
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
                    character.classDCs = new ClassDCs { Alchemist = 1 };
                    break;
                case Class.Barbarian:
                    character.maxHP = 12 + character.constitution_modifier;
                    character.currentHP = character.maxHP;
                    character.strength += 2;
                    character.proficiencies = new Proficiencies
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
                    character.classDCs = new ClassDCs { Barbarian = 1 };
                    break;
                case Class.Bard:
                    character.maxHP = 8 + character.constitution_modifier;
                    character.currentHP = character.maxHP;
                    character.charisma += 2;
                    character.proficiencies = new Proficiencies
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
                    character.maxHP = 10 + character.constitution_modifier;
                    character.currentHP = character.maxHP;
                    character.freeBoosts += 1;
                    Limiter.restrictedBoostReset();
                    Limiter.restrictedBoostsLimit[0] = true;
                    Limiter.restrictedBoostsLimit[1] = false;
                    character.proficiencies = new Proficiencies
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
                    character.classDCs = new ClassDCs { Champion = 1 };
                    break;
                case Class.Cleric:
                    character.maxHP = 8 + character.constitution_modifier;
                    character.currentHP = character.maxHP;
                    character.wisdom += 2;
                    character.proficiencies = new Proficiencies
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
                case Class.Fighter:
                    character.maxHP = 10 + character.constitution_modifier;
                    character.currentHP = character.maxHP;
                    character.proficiencies = new Proficiencies
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
                    character.classDCs = new ClassDCs { Fighter = 1 };
                    break;
            }
        }
    }
}
