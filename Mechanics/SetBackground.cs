namespace Pathfinder2E.Mechanics;

public static class SetBackground
{
	public static void Set(Character character, Background background)
	{
		switch (background)
		{
            case Background.Acolyte:
				character.background = background;
				character.freeBoosts += 1;
                character.restrictedBoosts += 1;
                Limiter.freeBoostReset();
                Limiter.restrictedBoostReset();
                Limiter.resetSkillValues(character.skills);
                character.skills.Religion = 1;
                Limiter.restrictedBoostsLimit[3] = true;
                Limiter.restrictedBoostsLimit[4] = true;
                break;
            case Background.Acrobat:
                character.background = background;
                character.freeBoosts += 1;
                character.restrictedBoosts += 1;
                Limiter.freeBoostReset();
                Limiter.restrictedBoostReset();
                Limiter.resetSkillValues(character.skills);
                character.skills.Acrobatics = 1;
                Limiter.restrictedBoostsLimit[0] = true;
                Limiter.restrictedBoostsLimit[1] = true;
                break;
            case Background.Animal_Whisperer:
                character.background = background;
                character.freeBoosts += 1;
                character.restrictedBoosts += 1;
                Limiter.freeBoostReset();
                Limiter.restrictedBoostReset();
                Limiter.resetSkillValues(character.skills);
                character.skills.Nature = 1;
                Limiter.restrictedBoostsLimit[4] = true;
                Limiter.restrictedBoostsLimit[5] = true;
                break;
            case Background.Artisan:
                character.background = background;
                character.freeBoosts += 1;
                character.restrictedBoosts += 1;
                Limiter.freeBoostReset();
                Limiter.restrictedBoostReset();
                Limiter.resetSkillValues(character.skills);
                character.skills.Crafting = 1;
                Limiter.restrictedBoostsLimit[0] = true;
                Limiter.restrictedBoostsLimit[3] = true;
                break;
            case Background.Artist:
                character.background = background;
                character.freeBoosts += 1;
                character.restrictedBoosts += 1;
                Limiter.freeBoostReset();
                Limiter.restrictedBoostReset();
                Limiter.resetSkillValues(character.skills);
                character.skills.Crafting = 1;
                Limiter.restrictedBoostsLimit[1] = true;
                Limiter.restrictedBoostsLimit[5] = true;
                break;
            case Background.Barkeep:
                character.background = background;
                character.freeBoosts += 1;
                character.restrictedBoosts += 1;
                Limiter.freeBoostReset();
                Limiter.restrictedBoostReset();
                Limiter.resetSkillValues(character.skills);
                character.skills.Diplomacy = 1;
                Limiter.restrictedBoostsLimit[2] = true;
                Limiter.restrictedBoostsLimit[5] = true;
                break;
            case Background.Barrister:
                character.background = background;
                character.freeBoosts += 1;
                character.restrictedBoosts += 1;
                Limiter.freeBoostReset();
                Limiter.restrictedBoostReset();
                Limiter.resetSkillValues(character.skills);
                character.skills.Diplomacy = 1;
                Limiter.restrictedBoostsLimit[3] = true;
                Limiter.restrictedBoostsLimit[5] = true;
                break;
            case Background.Bounty_Hunter:
                character.background = background;
                character.freeBoosts += 1;
                character.restrictedBoosts += 1;
                Limiter.freeBoostReset();
                Limiter.restrictedBoostReset();
                Limiter.resetSkillValues(character.skills);
                character.skills.Survival = 1;
                Limiter.restrictedBoostsLimit[0] = true;
                Limiter.restrictedBoostsLimit[4] = true;
                break;
            case Background.Charlatan:
                character.background = background;
                character.freeBoosts += 1;
                character.restrictedBoosts += 1;
                Limiter.freeBoostReset();
                Limiter.restrictedBoostReset();
                Limiter.resetSkillValues(character.skills);
                character.skills.Deception = 1;
                Limiter.restrictedBoostsLimit[3] = true;
                Limiter.restrictedBoostsLimit[5] = true;
                break;
            case Background.Criminal:
                character.background = background;
                character.freeBoosts += 1;
                character.restrictedBoosts += 1;
                Limiter.freeBoostReset();
                Limiter.restrictedBoostReset();
                Limiter.resetSkillValues(character.skills);
                character.skills.Stealth = 1;
                Limiter.restrictedBoostsLimit[1] = true;
                Limiter.restrictedBoostsLimit[3] = true;
                break;
            case Background.Detective:
                character.background = background;
                character.freeBoosts += 1;
                character.restrictedBoosts += 1;
                Limiter.freeBoostReset();
                Limiter.restrictedBoostReset();
                Limiter.resetSkillValues(character.skills);
                character.skills.Society = 1;
                Limiter.restrictedBoostsLimit[3] = true;
                Limiter.restrictedBoostsLimit[4] = true;
                break;
            case Background.Emissary:
                character.background = background;
                character.freeBoosts += 1;
                character.restrictedBoosts += 1;
                Limiter.freeBoostReset();
                Limiter.restrictedBoostReset();
                Limiter.resetSkillValues(character.skills);
                character.skills.Society = 1;
                Limiter.restrictedBoostsLimit[3] = true;
                Limiter.restrictedBoostsLimit[5] = true;
                break;
            case Background.Entertainer:
                character.background = background;
                character.freeBoosts += 1;
                character.restrictedBoosts += 1;
                Limiter.freeBoostReset();
                Limiter.restrictedBoostReset();
                Limiter.resetSkillValues(character.skills);
                character.skills.Performance = 1;
                Limiter.restrictedBoostsLimit[1] = true;
                Limiter.restrictedBoostsLimit[5] = true;
                break;
            case Background.Farmhand:
                character.background = background;
                character.freeBoosts += 1;
                character.restrictedBoosts += 1;
                Limiter.freeBoostReset();
                Limiter.restrictedBoostReset();
                Limiter.resetSkillValues(character.skills);
                character.skills.Athletics = 1;
                Limiter.restrictedBoostsLimit[2] = true;
                Limiter.restrictedBoostsLimit[4] = true;
                break;
            case Background.Field_Medic:
                character.background = background;
                character.freeBoosts += 1;
                character.restrictedBoosts += 1;
                Limiter.freeBoostReset();
                Limiter.restrictedBoostReset();
                Limiter.resetSkillValues(character.skills);
                character.skills.Medicine = 1;
                Limiter.restrictedBoostsLimit[2] = true;
                Limiter.restrictedBoostsLimit[4] = true;
                break;
            case Background.Fortune_Teller:
                character.background = background;
                character.freeBoosts += 1;
                character.restrictedBoosts += 1;
                Limiter.freeBoostReset();
                Limiter.restrictedBoostReset();
                Limiter.resetSkillValues(character.skills);
                character.skills.Occultism = 1;
                Limiter.restrictedBoostsLimit[3] = true;
                Limiter.restrictedBoostsLimit[5] = true;
                break;
            case Background.Gambler:
                character.background = background;
                character.freeBoosts += 1;
                character.restrictedBoosts += 1;
                Limiter.freeBoostReset();
                Limiter.restrictedBoostReset();
                Limiter.resetSkillValues(character.skills);
                character.skills.Deception = 1;
                Limiter.restrictedBoostsLimit[1] = true;
                Limiter.restrictedBoostsLimit[5] = true;
                break;
            case Background.Gladiator:
                character.background = background;
                character.freeBoosts += 1;
                character.restrictedBoosts += 1;
                Limiter.freeBoostReset();
                Limiter.restrictedBoostReset();
                Limiter.resetSkillValues(character.skills);
                character.skills.Performance = 1;
                Limiter.restrictedBoostsLimit[0] = true;
                Limiter.restrictedBoostsLimit[5] = true;
                break;
            case Background.Guard:
                character.background = background;
                character.freeBoosts += 1;
                character.restrictedBoosts += 1;
                Limiter.freeBoostReset();
                Limiter.restrictedBoostReset();
                Limiter.resetSkillValues(character.skills);
                character.skills.Intimidation = 1;
                Limiter.restrictedBoostsLimit[0] = true;
                Limiter.restrictedBoostsLimit[5] = true;
                break;
            case Background.Herbalist:
                character.background = background;
                character.freeBoosts += 1;
                character.restrictedBoosts += 1;
                Limiter.freeBoostReset();
                Limiter.restrictedBoostReset();
                Limiter.resetSkillValues(character.skills);
                character.skills.Nature = 1;
                Limiter.restrictedBoostsLimit[2] = true;
                Limiter.restrictedBoostsLimit[4] = true;
                break;
            case Background.Hermit:
                character.background = background;
                character.freeBoosts += 1;
                character.restrictedBoosts += 1;
                Limiter.freeBoostReset();
                Limiter.restrictedBoostReset();
                //Skill choice
                Limiter.restrictedBoostsLimit[2] = true;
                Limiter.restrictedBoostsLimit[3] = true;
                break;
            case Background.Hunter:
                character.background = background;
                character.freeBoosts += 1;
                character.restrictedBoosts += 1;
                Limiter.freeBoostReset();
                Limiter.restrictedBoostReset();
                Limiter.resetSkillValues(character.skills);
                character.skills.Survival = 1;
                Limiter.restrictedBoostsLimit[1] = true;
                Limiter.restrictedBoostsLimit[4] = true;
                break;
            case Background.Laborer:
                character.background = background;
                character.freeBoosts += 1;
                character.restrictedBoosts += 1;
                Limiter.freeBoostReset();
                Limiter.restrictedBoostReset();
                Limiter.resetSkillValues(character.skills);
                character.skills.Athletics = 1;
                Limiter.restrictedBoostsLimit[0] = true;
                Limiter.restrictedBoostsLimit[2] = true;
                break;
            case Background.Martial_Disciple:
                character.background = background;
                character.freeBoosts += 1;
                character.restrictedBoosts += 1;
                Limiter.freeBoostReset();
                Limiter.restrictedBoostReset();
                //Skill choice
                Limiter.restrictedBoostsLimit[0] = true;
                Limiter.restrictedBoostsLimit[1] = true;
                break;
            case Background.Merchant:
                character.background = background;
                character.freeBoosts += 1;
                character.restrictedBoosts += 1;
                Limiter.freeBoostReset();
                Limiter.restrictedBoostReset();
                Limiter.resetSkillValues(character.skills);
                character.skills.Diplomacy = 1;
                Limiter.restrictedBoostsLimit[3] = true;
                Limiter.restrictedBoostsLimit[5] = true;
                break;
            case Background.Miner:
                character.background = background;
                character.freeBoosts += 1;
                character.restrictedBoosts += 1;
                Limiter.freeBoostReset();
                Limiter.restrictedBoostReset();
                Limiter.resetSkillValues(character.skills);
                character.skills.Survival = 1;
                Limiter.restrictedBoostsLimit[0] = true;
                Limiter.restrictedBoostsLimit[4] = true;
                break;
            case Background.Noble:
                character.background = background;
                character.freeBoosts += 1;
                character.restrictedBoosts += 1;
                Limiter.freeBoostReset();
                Limiter.restrictedBoostReset();
                Limiter.resetSkillValues(character.skills);
                character.skills.Society = 1;
                Limiter.restrictedBoostsLimit[3] = true;
                Limiter.restrictedBoostsLimit[5] = true;
                break;
            case Background.Nomad:
                character.background = background;
                character.freeBoosts += 1;
                character.restrictedBoosts += 1;
                Limiter.freeBoostReset();
                Limiter.restrictedBoostReset();
                Limiter.resetSkillValues(character.skills);
                character.skills.Survival = 1;
                Limiter.restrictedBoostsLimit[2] = true;
                Limiter.restrictedBoostsLimit[4] = true;
                break;
            case Background.Prisoner:
                character.background = background;
                character.freeBoosts += 1;
                character.restrictedBoosts += 1;
                Limiter.freeBoostReset();
                Limiter.restrictedBoostReset();
                Limiter.resetSkillValues(character.skills);
                character.skills.Stealth = 1;
                Limiter.restrictedBoostsLimit[0] = true;
                Limiter.restrictedBoostsLimit[2] = true;
                break;
            case Background.Sailor:
                character.background = background;
                character.freeBoosts += 1;
                character.restrictedBoosts += 1;
                Limiter.freeBoostReset();
                Limiter.restrictedBoostReset();
                Limiter.resetSkillValues(character.skills);
                character.skills.Athletics = 1;
                Limiter.restrictedBoostsLimit[0] = true;
                Limiter.restrictedBoostsLimit[1] = true;
                break;
            case Background.Scholar:
                character.background = background;
                character.freeBoosts += 1;
                character.restrictedBoosts += 1;
                Limiter.freeBoostReset();
                Limiter.restrictedBoostReset();
                //Skill choice
                Limiter.restrictedBoostsLimit[3] = true;
                Limiter.restrictedBoostsLimit[4] = true;
                break;
            case Background.Scout:
                character.background = background;
                character.freeBoosts += 1;
                character.restrictedBoosts += 1;
                Limiter.freeBoostReset();
                Limiter.restrictedBoostReset();
                Limiter.resetSkillValues(character.skills);
                character.skills.Survival = 1;
                Limiter.restrictedBoostsLimit[1] = true;
                Limiter.restrictedBoostsLimit[4] = true;
                break;
            case Background.Street_Urchin:
                character.background = background;
                character.freeBoosts += 1;
                character.restrictedBoosts += 1;
                Limiter.freeBoostReset();
                Limiter.restrictedBoostReset();
                Limiter.resetSkillValues(character.skills);
                character.skills.Theivery = 1;
                Limiter.restrictedBoostsLimit[1] = true;
                Limiter.restrictedBoostsLimit[2] = true;
                break;
            case Background.Tinker:
                character.background = background;
                character.freeBoosts += 1;
                character.restrictedBoosts += 1;
                Limiter.freeBoostReset();
                Limiter.restrictedBoostReset();
                Limiter.resetSkillValues(character.skills);
                character.skills.Crafting = 1;
                Limiter.restrictedBoostsLimit[1] = true;
                Limiter.restrictedBoostsLimit[3] = true;
                break;
            case Background.Warrior:
                character.background = background;
                character.freeBoosts += 1;
                character.restrictedBoosts += 1;
                Limiter.freeBoostReset();
                Limiter.restrictedBoostReset();
                Limiter.resetSkillValues(character.skills);
                character.skills.Intimidation = 1;
                Limiter.restrictedBoostsLimit[0] = true;
                Limiter.restrictedBoostsLimit[2] = true;
                break;
        }
    }

}
