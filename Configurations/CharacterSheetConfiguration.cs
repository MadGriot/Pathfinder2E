using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

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
