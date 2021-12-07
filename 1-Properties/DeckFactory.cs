namespace Properties
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A factory class for building <see cref="ISet{T}">decks</see> of <see cref="Card"/>s.
    /// </summary>
    public class DeckFactory
    {
        private string[] _seeds;
        private string[] _names;

        // TODO improve
        public IList<string> Seeds
        {
            get => _seeds.ToList();
            set => _seeds = value.ToArray();
        }

        // TODO improve
        public IList<string> Names
        {
            get=>names.ToList();
        }

        // TODO improve
        public void SetNames(IList<string> names)
        {
            names = names.ToArray();
        }

        // TODO improve
        public int DeckSize
        {
            get=> names.Length * this.seeds.Length;
        }

        /// TODO improve
        public ISet<Card> Deck
        {

           get=> new HashSet<Card>(Enumerable
                .Range(0, names.Length)
                .SelectMany(i => Enumerable
                    .Repeat(i,seeds.Length)
                    .Zip(
                        Enumerable.Range(0, seeds.Length),
                        (n, s) => Tuple.Create(names[n], seeds[s], n)))
                .Select(tuple => new Card(tuple))
                .ToList());
        }
    }
}
