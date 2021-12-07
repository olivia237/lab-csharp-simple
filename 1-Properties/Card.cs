namespace Properties
{
    using System;

    /// <summary>
    /// The class models a card.
    /// </summary>
    public class Card
    {
        private int seedReadCount;

        /// <summary>
        /// Initializes a new instance of the <see cref="Card"/> class.
        /// </summary>
        /// <param name="name">the name of the card.</param>
        /// <param name="seed">the seed of the card.</param>
        /// <param name="ordinal">the ordinal number of the card.</param>
        public Card(string name, string seed, int ordinal)
        {
            this.Name = name;
            this.Ordinal = ordinal;
            this.Seed = seed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Card"/> class.
        /// </summary>
        /// <param name="tuple">the informations about the card as a tuple.</param>
        internal Card(Tuple<string, string, int> tuple) : this(tuple.Item1, tuple.Item2, tuple.Item3)
        {
        }

        public string Seed { get; } 

        public string Name { get; }

        public int Ordinal { get;  }

        /// <inheritdoc cref="object.ToString"/>
        public override string ToString()
        {
            // TODO understand string interpolation
            return $"{GetType().Name}(Name={GetName()}, Seed={GetSeed()}, Ordinal={GetOrdinal()})";
        }

        public override bool Equals(object obj)
        {
            return obj is Card card &&
                   seed == card.seed &&
                   name == card.name &&
                   ordinal == card.ordinal;
        }


        public override int GetHashCode()
        {
            return HashCode.Combine(seed, name, ordinal);
        }
    }
}
