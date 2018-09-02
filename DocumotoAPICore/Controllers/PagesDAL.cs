using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DocumotoAPI.Controllers
{
    public static class PagesDAL
    {
        static PagesDAL()
        {
            Pages = new List<Page>()
            {
                new Page()
                {
                    Id = 1,
                    Name = "Page 1",
                    Tags = new List<Tag>(){ Tags[0], Tags[2] },
                    Parts = new List<Part>() {Parts[0], Parts[1] },
                    Translations = new List<Translation>() { Translations[1], Translations[2] }
                },
                new Page()
                {
                    Id = 2,
                    Name = "Page 2",
                    Tags = new List<Tag>(){ Tags[1], Tags[2] },
                    Parts = new List<Part>() {Parts[2], Parts[3] },
                    Translations = new List<Translation>() { Translations[2], Translations[3] }
                },
                new Page()
                {
                    Id = 3,
                    Name = "Page 3",
                    Tags = new List<Tag>(){ Tags[1], Tags[2] },
                    Parts = new List<Part>() {Parts[4] },
                    Translations = new List<Translation>() { Translations[4] }
                },
                new Page()
                {
                    Id = 4,
                    Name = "Page 4",
                    Tags = new List<Tag>(){ Tags[1], Tags[3], Tags[4] },
                    Parts = new List<Part>() {Parts[5], Parts[6], Parts[7] },
                    Translations = new List<Translation>() { Translations[5], Translations[6], Translations[7] }
                },
                new Page()
                {
                    Id = 5,
                    Name = "Page 5",
                    Tags = new List<Tag>(){ Tags[3], Tags[4] },
                    Parts = new List<Part>() {Parts[8] },
                    Translations = new List<Translation>() { Translations[8] }
                },
            };
        }

        public static List<Tag> Tags = new List<Tag>()
        {
            new Tag() { Id=1, Name = "front" },
            new Tag() { Id=2, Name = "important" },
            new Tag() { Id=3, Name = "new" },
            new Tag() { Id=4, Name = "spicy" },
            new Tag() { Id=5, Name = "scarry" },
        };

        public static List<Part> Parts = new List<Part>()
        {
            new Part() { Id=1, Words = "this is the first paragraph: how boring but I have no idea what to say" },
            new Part() { Id=2, Words = "this is the second paragraph: I am still clueless" },
            new Part() { Id=3, Words = "this is the third paragraph: I still have a long way to go" },
            new Part() { Id=4, Words = "this is the fourth paragraph: I can do this" },
            new Part() { Id=5, Words = "this is the fifth paragraph: half way?" },
            new Part() { Id=6, Words = "this is the sixth paragraph: getting more exciting" },
            new Part() { Id=7, Words = "this is the seventh paragraph: in the murder mystery we would have introduces a lot of clues by now" },
            new Part() { Id=8, Words = "this is the eighth paragraph: inspector is about to die" },
            new Part() { Id=9, Words = "this is the ninth paragraph: happy ending" },
        };

        public static List<Translation> Translations = new List<Translation>()
        {
            new Translation() { Id=1,  Words = "Das ist der erste Absatz: wie langweilig, aber ich habe keine Ahnung, was ich sagen soll" },
            new Translation() { Id=2, Words = "Das ist der zweite Absatz: Ich bin immer noch ahnungslos" },
            new Translation() { Id=3, Words = "Das ist der dritte Absatz: Ich habe noch einen langen Weg vor mir" },
            new Translation() { Id=4, Words = "Das ist der vierte Absatz: Ich kann das" },
            new Translation() { Id=5, Words = "Das ist der fünfte Absatz: auf halbem Weg?" },
            new Translation() { Id=6, Words = "Dies ist der sechste Absatz: immer spannender" },
            new Translation() { Id=7, Words = "Das ist der siebte Absatz: im mordmisterium hätten wir inzwischen viele Anhaltspunkte eingeführt" },
            new Translation() { Id=8, Words = "Dies ist der siebte Absatz: im mordgeheimnis hätten wir inzwischen viele Anhaltspunkte eingeführt" },
            new Translation() { Id=9, Words = "Das ist der neunte Absatz: Happy End" },
        };

        public static IEnumerable<Page> Pages = new List<Page>();
    }
}