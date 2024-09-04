using System;

public static class SetBackground
{
	public static void Set(Character character, Background background)
	{
		switch (background)
		{
        //    Acrobat,
        //Animal_Whisperer,
        //Artisan,
        //Artist,
        //Barkeep,
        //Barrister,
        //Bounty_Hunter,
        //Charlatan,
        //Criminal,
        //Detective,
        //Emissary,
        //Entertainer,
        //Farmhand,
        //Field_Medic,
        //Fortune_Teller,
        //Gambler,
        //Gladiator,
        //Guard,
        //Herbalist,
        //Hermit,
        //Hunter,
        //Laborer,
        //Martial_Disciple,
        //Merchant,
        //Miner,
        //Noble,
        //Nomad,
        //None,
        //Prisoner,
        //Sailor,
        //Scholar,
        //Street_Urchin,
        //Tinker,
        //Warrior

            case Background.Acolyte
				character.background = background;
				character.freeBoosts += 1;
                Limiter.restrictedBoostsLimit[4] = true;
                Limiter.restrictedBoostsLimit[5] = true;
            case Background.Acrobat
                character.background = background;
                character.freeBoosts += 1;
                Limiter.restrictedBoostsLimit[0] = true;
                Limiter.restrictedBoostsLimit[1] = true;

            //set Limits on limiter later.
            case Background.Animal_Whisperer
                character.background = background;
                character.freeBoosts += 1;
                Limiter.restrictedBoostsLimit[4] = true;
                Limiter.restrictedBoostsLimit[6] = true;
            //set Limits on limiter later.
            case Background.Artisan
                character.background = background;
                character.freeBoosts += 1;
                Limiter.restrictedBoostsLimit[0] = true;
                Limiter.restrictedBoostsLimit[3] = true;
            //set Limits on limiter later
            case Background.Artist
                character.background = background;
                character.freeBoosts += 1;
                Limiter.restrictedBoostsLimit[1] = true;
                Limiter.restrictedBoostsLimit[6] = true;
            //set Limits on limiter later.
            case Background.Barkeep
                character.background = background;
                character.freeBoosts += 1;
                Limiter.restrictedBoostsLimit[3] = true;
                Limiter.restrictedBoostsLimit[6] = true;
                //set Limits on limiter later.

        }
    }

}
