﻿using Discord.Interactions;

namespace Valiant.Interactions;

public class FaqModule : InteractionModuleBase<SocketInteractionContext>//, IDisposable
{
    //private readonly LiteDatabase _db = new("Filename=./data/faq.db;Connection=shared");

    //private readonly IStringLocalizer _localizer;

    //public FaqModule(IStringLocalizerFactory factory)
    //{
    //    _localizer = factory.Create(nameof(FaqModule), "locales/en-US");
    //}

    //public void Dispose() => _db.Dispose();

    //[SlashCommand("faq", "")]
    //public async Task FaqAsync()
    //{
    //    var embed = new EmbedBuilder();
    //    IStringLocalizerFactory factory;
    //    embed.Description += "\n\n" + _localizer["faq_embed_footer", ];
    //}

    //[SlashCommand("faq", "Search for answers to frequently asked questions.")]
    //public async Task FaqAsync([Summary("faq_id"), Autocomplete]string faqId, IUser mention = null)
    //{
    //    var result = _db.GetCollection<FaqCategory>()
    //        .Query().ToList().SelectMany(x => x.Entries)
    //        .SingleOrDefault(x => x.Id.Equals(faqId, StringComparison.InvariantCultureIgnoreCase));

    //    var embed = new EmbedBuilder()
    //        .WithDescription($"**{result.Id}.** {result.Title}");
    //    var button = new ComponentBuilder()
    //        .WithButton("See Answer", style: ButtonStyle.Link, url: result.ThreadUrl);

    //    await RespondAsync(mention?.Mention, embeds: [embed.Build()], components: button.Build());
    //}

    //[AutocompleteCommand("faq_id", "faq")]
    //public async Task AutocompleteAsync()
    //{
    //    var interaction = (SocketAutocompleteInteraction)Context.Interaction;
    //    string userInput = interaction.Data.Current.Value.ToString();
    //    if (string.IsNullOrWhiteSpace(userInput))
    //    {
    //        await interaction.RespondAsync(default);
    //        return;
    //    }

    //    var entries = _db.GetCollection<FaqCategory>()
    //        .Query().ToList().SelectMany(x => x.Entries);
    //    var matches = entries.Where(x => x.Id.Equals(userInput, StringComparison.InvariantCultureIgnoreCase)
    //        || x.Title.Contains(userInput, StringComparison.InvariantCultureIgnoreCase)).Take(25);
    //    var results = matches.Select(x => new AutocompleteResult($"{x.Id}. {x.Title.Substring(0, Math.Min(95, x.Title.Length))}", x.Id));

    //    await interaction.RespondAsync(results);
    //}
}
