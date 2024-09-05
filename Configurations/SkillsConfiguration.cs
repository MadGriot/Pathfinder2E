using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Pathfinder2E.Configurations
{
    internal class SkillsConfiguration : IEntityTypeConfiguration<Skills>
    {
        public void Configure(EntityTypeBuilder<Skills> builder)
        {
            builder.HasData(
                new Skills
                {
                    SkillsId = 1,
                    CharacterSheetId = 1,
                },
                new Skills
                {
                    SkillsId = 2,
                    CharacterSheetId = 2,
                },
                new Skills
                {
                    SkillsId = 3,
                    CharacterSheetId = 3,
                },
                new Skills
                {
                    SkillsId = 4,
                    CharacterSheetId = 4,
                }
            );
        }
    }
}
