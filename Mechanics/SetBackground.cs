namespace Pathfinder2E.Mechanics;

public static class SetBackground
{
	public static void Set(CharacterSheet character, Background background)
	{
		switch (background)
		{
            case Background.Acolyte:
				character.Background = background;
				character.FreeBoosts += 1;
                character.RestrictedBoosts += 1;
                Limiter.freeBoostReset();
                Limiter.restrictedBoostReset();
                Limiter.resetSkillValues(character.Skills);
                character.Skills.Religion = 1;
                Limiter.RestrictedBoostsLimit[3] = true;
                Limiter.RestrictedBoostsLimit[4] = true;
                break;
            case Background.Acrobat:
                character.Background = background;
                character.FreeBoosts += 1;
                character.RestrictedBoosts += 1;
                Limiter.freeBoostReset();
                Limiter.restrictedBoostReset();
                Limiter.resetSkillValues(character.Skills);
                character.Skills.Acrobatics = 1;
                Limiter.RestrictedBoostsLimit[0] = true;
                Limiter.RestrictedBoostsLimit[1] = true;
                break;
            case Background.Animal_Whisperer:
                character.Background = background;
                character.FreeBoosts += 1;
                character.RestrictedBoosts += 1;
                Limiter.freeBoostReset();
                Limiter.restrictedBoostReset();
                Limiter.resetSkillValues(character.Skills);
                character.Skills.Nature = 1;
                Limiter.RestrictedBoostsLimit[4] = true;
                Limiter.RestrictedBoostsLimit[5] = true;
                break;
            case Background.Artisan:
                character.Background = background;
                character.FreeBoosts += 1;
                character.RestrictedBoosts += 1;
                Limiter.freeBoostReset();
                Limiter.restrictedBoostReset();
                Limiter.resetSkillValues(character.Skills);
                character.Skills.Crafting = 1;
                Limiter.RestrictedBoostsLimit[0] = true;
                Limiter.RestrictedBoostsLimit[3] = true;
                break;
            case Background.Artist:
                character.Background = background;
                character.FreeBoosts += 1;
                character.RestrictedBoosts += 1;
                Limiter.freeBoostReset();
                Limiter.restrictedBoostReset();
                Limiter.resetSkillValues(character.Skills);
                character.Skills.Crafting = 1;
                Limiter.RestrictedBoostsLimit[1] = true;
                Limiter.RestrictedBoostsLimit[5] = true;
                break;
            case Background.Barkeep:
                character.Background = background;
                character.FreeBoosts += 1;
                character.RestrictedBoosts += 1;
                Limiter.freeBoostReset();
                Limiter.restrictedBoostReset();
                Limiter.resetSkillValues(character.Skills);
                character.Skills.Diplomacy = 1;
                Limiter.RestrictedBoostsLimit[2] = true;
                Limiter.RestrictedBoostsLimit[5] = true;
                break;
            case Background.Barrister:
                character.Background = background;
                character.FreeBoosts += 1;
                character.RestrictedBoosts += 1;
                Limiter.freeBoostReset();
                Limiter.restrictedBoostReset();
                Limiter.resetSkillValues(character.Skills);
                character.Skills.Diplomacy = 1;
                Limiter.RestrictedBoostsLimit[3] = true;
                Limiter.RestrictedBoostsLimit[5] = true;
                break;
            case Background.Bounty_Hunter:
                character.Background = background;
                character.FreeBoosts += 1;
                character.RestrictedBoosts += 1;
                Limiter.freeBoostReset();
                Limiter.restrictedBoostReset();
                Limiter.resetSkillValues(character.Skills);
                character.Skills.Survival = 1;
                Limiter.RestrictedBoostsLimit[0] = true;
                Limiter.RestrictedBoostsLimit[4] = true;
                break;
            case Background.Charlatan:
                character.Background = background;
                character.FreeBoosts += 1;
                character.RestrictedBoosts += 1;
                Limiter.freeBoostReset();
                Limiter.restrictedBoostReset();
                Limiter.resetSkillValues(character.Skills);
                character.Skills.Deception = 1;
                Limiter.RestrictedBoostsLimit[3] = true;
                Limiter.RestrictedBoostsLimit[5] = true;
                break;
            case Background.Criminal:
                character.Background = background;
                character.FreeBoosts += 1;
                character.RestrictedBoosts += 1;
                Limiter.freeBoostReset();
                Limiter.restrictedBoostReset();
                Limiter.resetSkillValues(character.Skills);
                character.Skills.Stealth = 1;
                Limiter.RestrictedBoostsLimit[1] = true;
                Limiter.RestrictedBoostsLimit[3] = true;
                break;
            case Background.Detective:
                character.Background = background;
                character.FreeBoosts += 1;
                character.RestrictedBoosts += 1;
                Limiter.freeBoostReset();
                Limiter.restrictedBoostReset();
                Limiter.resetSkillValues(character.Skills);
                character.Skills.Society = 1;
                Limiter.RestrictedBoostsLimit[3] = true;
                Limiter.RestrictedBoostsLimit[4] = true;
                break;
            case Background.Emissary:
                character.Background = background;
                character.FreeBoosts += 1;
                character.RestrictedBoosts += 1;
                Limiter.freeBoostReset();
                Limiter.restrictedBoostReset();
                Limiter.resetSkillValues(character.Skills);
                character.Skills.Society = 1;
                Limiter.RestrictedBoostsLimit[3] = true;
                Limiter.RestrictedBoostsLimit[5] = true;
                break;
            case Background.Entertainer:
                character.Background = background;
                character.FreeBoosts += 1;
                character.RestrictedBoosts += 1;
                Limiter.freeBoostReset();
                Limiter.restrictedBoostReset();
                Limiter.resetSkillValues(character.Skills);
                character.Skills.Performance = 1;
                Limiter.RestrictedBoostsLimit[1] = true;
                Limiter.RestrictedBoostsLimit[5] = true;
                break;
            case Background.Farmhand:
                character.Background = background;
                character.FreeBoosts += 1;
                character.RestrictedBoosts += 1;
                Limiter.freeBoostReset();
                Limiter.restrictedBoostReset();
                Limiter.resetSkillValues(character.Skills);
                character.Skills.Athletics = 1;
                Limiter.RestrictedBoostsLimit[2] = true;
                Limiter.RestrictedBoostsLimit[4] = true;
                break;
            case Background.Field_Medic:
                character.Background = background;
                character.FreeBoosts += 1;
                character.RestrictedBoosts += 1;
                Limiter.freeBoostReset();
                Limiter.restrictedBoostReset();
                Limiter.resetSkillValues(character.Skills);
                character.Skills.Medicine = 1;
                Limiter.RestrictedBoostsLimit[2] = true;
                Limiter.RestrictedBoostsLimit[4] = true;
                break;
            case Background.Fortune_Teller:
                character.Background = background;
                character.FreeBoosts += 1;
                character.RestrictedBoosts += 1;
                Limiter.freeBoostReset();
                Limiter.restrictedBoostReset();
                Limiter.resetSkillValues(character.Skills);
                character.Skills.Occultism = 1;
                Limiter.RestrictedBoostsLimit[3] = true;
                Limiter.RestrictedBoostsLimit[5] = true;
                break;
            case Background.Gambler:
                character.Background = background;
                character.FreeBoosts += 1;
                character.RestrictedBoosts += 1;
                Limiter.freeBoostReset();
                Limiter.restrictedBoostReset();
                Limiter.resetSkillValues(character.Skills);
                character.Skills.Deception = 1;
                Limiter.RestrictedBoostsLimit[1] = true;
                Limiter.RestrictedBoostsLimit[5] = true;
                break;
            case Background.Gladiator:
                character.Background = background;
                character.FreeBoosts += 1;
                character.RestrictedBoosts += 1;
                Limiter.freeBoostReset();
                Limiter.restrictedBoostReset();
                Limiter.resetSkillValues(character.Skills);
                character.Skills.Performance = 1;
                Limiter.RestrictedBoostsLimit[0] = true;
                Limiter.RestrictedBoostsLimit[5] = true;
                break;
            case Background.Guard:
                character.Background = background;
                character.FreeBoosts += 1;
                character.RestrictedBoosts += 1;
                Limiter.freeBoostReset();
                Limiter.restrictedBoostReset();
                Limiter.resetSkillValues(character.Skills);
                character.Skills.Intimidation = 1;
                Limiter.RestrictedBoostsLimit[0] = true;
                Limiter.RestrictedBoostsLimit[5] = true;
                break;
            case Background.Herbalist:
                character.Background = background;
                character.FreeBoosts += 1;
                character.RestrictedBoosts += 1;
                Limiter.freeBoostReset();
                Limiter.restrictedBoostReset();
                Limiter.resetSkillValues(character.Skills);
                character.Skills.Nature = 1;
                Limiter.RestrictedBoostsLimit[2] = true;
                Limiter.RestrictedBoostsLimit[4] = true;
                break;
            case Background.Hermit:
                character.Background = background;
                character.FreeBoosts += 1;
                character.RestrictedBoosts += 1;
                Limiter.freeBoostReset();
                Limiter.restrictedBoostReset();
                //Skill choice
                Limiter.RestrictedBoostsLimit[2] = true;
                Limiter.RestrictedBoostsLimit[3] = true;
                break;
            case Background.Hunter:
                character.Background = background;
                character.FreeBoosts += 1;
                character.RestrictedBoosts += 1;
                Limiter.freeBoostReset();
                Limiter.restrictedBoostReset();
                Limiter.resetSkillValues(character.Skills);
                character.Skills.Survival = 1;
                Limiter.RestrictedBoostsLimit[1] = true;
                Limiter.RestrictedBoostsLimit[4] = true;
                break;
            case Background.Laborer:
                character.Background = background;
                character.FreeBoosts += 1;
                character.RestrictedBoosts += 1;
                Limiter.freeBoostReset();
                Limiter.restrictedBoostReset();
                Limiter.resetSkillValues(character.Skills);
                character.Skills.Athletics = 1;
                Limiter.RestrictedBoostsLimit[0] = true;
                Limiter.RestrictedBoostsLimit[2] = true;
                break;
            case Background.Martial_Disciple:
                character.Background = background;
                character.FreeBoosts += 1;
                character.RestrictedBoosts += 1;
                Limiter.freeBoostReset();
                Limiter.restrictedBoostReset();
                //Skill choice
                Limiter.RestrictedBoostsLimit[0] = true;
                Limiter.RestrictedBoostsLimit[1] = true;
                break;
            case Background.Merchant:
                character.Background = background;
                character.FreeBoosts += 1;
                character.RestrictedBoosts += 1;
                Limiter.freeBoostReset();
                Limiter.restrictedBoostReset();
                Limiter.resetSkillValues(character.Skills);
                character.Skills.Diplomacy = 1;
                Limiter.RestrictedBoostsLimit[3] = true;
                Limiter.RestrictedBoostsLimit[5] = true;
                break;
            case Background.Miner:
                character.Background = background;
                character.FreeBoosts += 1;
                character.RestrictedBoosts += 1;
                Limiter.freeBoostReset();
                Limiter.restrictedBoostReset();
                Limiter.resetSkillValues(character.Skills);
                character.Skills.Survival = 1;
                Limiter.RestrictedBoostsLimit[0] = true;
                Limiter.RestrictedBoostsLimit[4] = true;
                break;
            case Background.Noble:
                character.Background = background;
                character.FreeBoosts += 1;
                character.RestrictedBoosts += 1;
                Limiter.freeBoostReset();
                Limiter.restrictedBoostReset();
                Limiter.resetSkillValues(character.Skills);
                character.Skills.Society = 1;
                Limiter.RestrictedBoostsLimit[3] = true;
                Limiter.RestrictedBoostsLimit[5] = true;
                break;
            case Background.Nomad:
                character.Background = background;
                character.FreeBoosts += 1;
                character.RestrictedBoosts += 1;
                Limiter.freeBoostReset();
                Limiter.restrictedBoostReset();
                Limiter.resetSkillValues(character.Skills);
                character.Skills.Survival = 1;
                Limiter.RestrictedBoostsLimit[2] = true;
                Limiter.RestrictedBoostsLimit[4] = true;
                break;
            case Background.Prisoner:
                character.Background = background;
                character.FreeBoosts += 1;
                character.RestrictedBoosts += 1;
                Limiter.freeBoostReset();
                Limiter.restrictedBoostReset();
                Limiter.resetSkillValues(character.Skills);
                character.Skills.Stealth = 1;
                Limiter.RestrictedBoostsLimit[0] = true;
                Limiter.RestrictedBoostsLimit[2] = true;
                break;
            case Background.Sailor:
                character.Background = background;
                character.FreeBoosts += 1;
                character.RestrictedBoosts += 1;
                Limiter.freeBoostReset();
                Limiter.restrictedBoostReset();
                Limiter.resetSkillValues(character.Skills);
                character.Skills.Athletics = 1;
                Limiter.RestrictedBoostsLimit[0] = true;
                Limiter.RestrictedBoostsLimit[1] = true;
                break;
            case Background.Scholar:
                character.Background = background;
                character.FreeBoosts += 1;
                character.RestrictedBoosts += 1;
                Limiter.freeBoostReset();
                Limiter.restrictedBoostReset();
                //Skill choice
                Limiter.RestrictedBoostsLimit[3] = true;
                Limiter.RestrictedBoostsLimit[4] = true;
                break;
            case Background.Scout:
                character.Background = background;
                character.FreeBoosts += 1;
                character.RestrictedBoosts += 1;
                Limiter.freeBoostReset();
                Limiter.restrictedBoostReset();
                Limiter.resetSkillValues(character.Skills);
                character.Skills.Survival = 1;
                Limiter.RestrictedBoostsLimit[1] = true;
                Limiter.RestrictedBoostsLimit[4] = true;
                break;
            case Background.Street_Urchin:
                character.Background = background;
                character.FreeBoosts += 1;
                character.RestrictedBoosts += 1;
                Limiter.freeBoostReset();
                Limiter.restrictedBoostReset();
                Limiter.resetSkillValues(character.Skills);
                character.Skills.Theivery = 1;
                Limiter.RestrictedBoostsLimit[1] = true;
                Limiter.RestrictedBoostsLimit[2] = true;
                break;
            case Background.Tinker:
                character.Background = background;
                character.FreeBoosts += 1;
                character.RestrictedBoosts += 1;
                Limiter.freeBoostReset();
                Limiter.restrictedBoostReset();
                Limiter.resetSkillValues(character.Skills);
                character.Skills.Crafting = 1;
                Limiter.RestrictedBoostsLimit[1] = true;
                Limiter.RestrictedBoostsLimit[3] = true;
                break;
            case Background.Warrior:
                character.Background = background;
                character.FreeBoosts += 1;
                character.RestrictedBoosts += 1;
                Limiter.freeBoostReset();
                Limiter.restrictedBoostReset();
                Limiter.resetSkillValues(character.Skills);
                character.Skills.Intimidation = 1;
                Limiter.RestrictedBoostsLimit[0] = true;
                Limiter.RestrictedBoostsLimit[2] = true;
                break;
        }
    }

}
