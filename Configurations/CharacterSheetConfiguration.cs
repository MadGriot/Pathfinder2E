using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pathfinder2E.Mechanics;
using Pathfinder2E.Mechanics.Actions;

namespace Pathfinder2E.Configurations
{
    internal class CharacterSheetConfiguration : IEntityTypeConfiguration<CharacterSheetModel>
    {
        public void Configure(EntityTypeBuilder<CharacterSheetModel> builder)
        {
            builder.HasData(
                  new CharacterSheetModel
                  {
                      CharacterSheetId = 1,
                      Level = 1,
                      FirstName = "Konjit",
                      LastName = "Munaye",
                      CurrentHP = 15,
                      MaxHP = 15,
                      Ancestry = Ancestry.Elf,
                      Background = Background.Nomad,
                      Alignment = Alignment.LawfulGood,
                      CharacterClass = Class.Ranger,
                      XP = 0,
                      Speed = 30,
                      Size = Size.Medium,
                      FreeBoosts = 0,
                      Languages = new List<Language>
                      {
                          Language.Mwangi,
                          Language.Taldane,
                      },
                      Resistances = new List<DamageType>
                      {
                          DamageType.Poison,
                          DamageType.Bleed,
                      },
                      ResistanceValues = new List<int>
                      {
                          2,
                          2,
                      },
                  },
                  new CharacterSheetModel
                  {
                      CharacterSheetId = 2,
                      Level = 1,
                      FirstName = "Kanandi",
                      LastName = "Oladoyinbo",
                      CurrentHP = 22,
                      MaxHP = 22,
                      Ancestry = Ancestry.Human,
                      Background = Background.Laborer,
                      Alignment = Alignment.ChaoticNeutral,
                      CharacterClass = Class.Barbarian,
                      XP = 0,
                      Speed = 25,
                      Size = Size.Medium,
                      FreeBoosts = 0,
                      Languages = new List<Language>
                      {
                          Language.Mwangi,
                          Language.Taldane,
                      },
                      Weaknesses = new List<DamageType>
                      {
                          DamageType.Mental,
                          DamageType.Poison,
                      },
                      WeaknessValues = new List<int>
                      {
                          3,
                          2,
                      },
                  },
                  new CharacterSheetModel
                  {
                      CharacterSheetId = 3,
                      Level = 1,
                      FirstName = "Cris",
                      LastName = "Marcellus",
                      CurrentHP = 14,
                      MaxHP = 14,
                      Ancestry = Ancestry.Human,
                      Background = Background.Emissary,
                      Alignment = Alignment.NeutralGood,
                      CharacterClass = Class.Wizard,
                      Size = Size.Medium,
                      XP = 0,
                      Speed = 25,
                      FreeBoosts = 0,
                      Languages = new List<Language>
                      {
                          Language.Mwangi,
                          Language.Taldane,
                      },

                  },
                  new CharacterSheetModel
                  {
                      CharacterSheetId = 4,
                      Level = 1,
                      FirstName = "Unkown",
                      LastName = "Person",
                      CurrentHP = 0,
                      MaxHP = 0,
                      Ancestry = Ancestry.Human,
                      Background = Background.None,
                      Alignment = Alignment.Neutral,
                      CharacterClass = Class.Fighter,
                      Size = Size.Medium,
                      XP = 0,
                      Speed = 25,
                      FreeBoosts = 0,
                      Languages = new List<Language>
                      {
                          Language.Mwangi,
                      },

                  }
              );
        }
    }
}
