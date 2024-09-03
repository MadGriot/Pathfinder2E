
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Pathfinder2E.Configurations
{
    internal class AbilityScoreConfiguration : IEntityTypeConfiguration<AbilityScore>
    {
        public void Configure(EntityTypeBuilder<AbilityScore> builder)
        {
            builder.HasData(
                new AbilityScore
                {
                    AbilityScoreId = 1,
                    CharacterSheetId = 1,
                    strength = 10,
                    constitution = 10,
                    dexterity = 10,
                    wisdom = 10,
                    intelligence = 10,
                    charisma = 10,
                },
                new AbilityScore
                {
                    AbilityScoreId = 2,
                    CharacterSheetId = 2,
                    strength = 10,
                    constitution = 10,
                    dexterity = 10,
                    wisdom = 10,
                    intelligence = 10,
                    charisma = 10,
                },
                new AbilityScore
                {
                    AbilityScoreId = 3,
                    CharacterSheetId = 3,
                    strength = 10,
                    constitution = 10,
                    dexterity = 10,
                    wisdom = 10,
                    intelligence = 10,
                    charisma = 10,
                },
                new AbilityScore
                {
                    AbilityScoreId = 4,
                    CharacterSheetId = 4,
                    strength = 10,
                    constitution = 10,
                    dexterity = 10,
                    wisdom = 10,
                    intelligence = 10,
                    charisma = 10,
                }
            );
        }
    }
}
