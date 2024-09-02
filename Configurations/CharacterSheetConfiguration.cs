using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pathfinder2E.Mechanics;

namespace Pathfinder2E.Configurations
{
    internal class CharacterSheetConfiguration : IEntityTypeConfiguration<CharacterSheet>
    {
        public void Configure(EntityTypeBuilder<CharacterSheet> builder)
        {
            builder.HasData(
                  new CharacterSheet
                  {
                      CharacterSheetId = 1,
                      level = 1,
                      firstName = "Konjit",
                      lastName = "Munaye",
                      currentHP = 15,
                      maxHP = 15,
                      ancestry = Ancestry.Elf,
                      background = Background.Nomad,
                      alignment = Alignment.LawfulGood,
                      characterClass = Class.Ranger,
                      resistances = new HashSet<DamageType>
                      {
                          DamageType.Poison,
                          DamageType.Bleed,
                      },
                      resistanceValues = new List<int>
                      {
                          2,
                          2,
                      }

                  },
                  new CharacterSheet
                  {
                      CharacterSheetId = 2,
                      level = 1,
                      firstName = "Kanandi",
                      lastName = "Oladoyinbo",
                      currentHP = 22,
                      maxHP = 22,
                      ancestry = Ancestry.Human,
                      background = Background.Laborer,
                      alignment = Alignment.ChaoticNeutral,
                      characterClass = Class.Barbarian,
                      weaknesses = new HashSet<DamageType>
                      {
                          DamageType.Mental,
                          DamageType.Poison,
                      },
                      weaknessValues = new List<int>
                      {
                          3,
                          2,
                      }
                  },
                  new CharacterSheet
                  {
                      CharacterSheetId = 3,
                      level = 1,
                      firstName = "Cris",
                      lastName = "Marcellus",
                      currentHP = 14,
                      maxHP = 14,
                      ancestry = Ancestry.Human,
                      background = Background.Emissary,
                      alignment = Alignment.NeutralGood,
                      characterClass = Class.Wizard,
                  }
              );
        }
    }
}
