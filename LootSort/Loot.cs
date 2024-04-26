using System;

namespace LootSort
{
    /// <summary>
    /// The Loot class should implement IComparable<Loot>
    /// </summary>
    public class Loot : IComparable<Loot>
    {
        /// <summary>Type of loot.</summary>
        public LootType Kind { get; }

        /// <summary>Loot description.</summary>
        public string Description { get; }

        /// <summary>Loot value.</summary>
        public float Value { get; }

        /// <summary>
        /// Create a new instance of loot.
        /// </summary>
        /// <param name="kind">Type of loot.</param>
        /// <param name="description">Loot description.</param>
        /// <param name="value">Loot value.</param>
        public Loot(LootType kind, string description, float value)
        {
            Kind = kind;
            Description = description;
            Value = value;
        }

        /// <summary>
        /// Return a nicely formatted string representing the loot instance.
        /// </summary>
        /// <returns>
        /// A nicely formatted string representing the loot instance.
        /// </returns>
        public override string ToString() =>
            $"[{Kind,15}]\t{Value:f2}\t{Description}";

        /// <summary>
        /// Compare the current Loot object with another Loot object.
        /// </summary>
        /// <param name="other">The other Loot object to compare with.</param>
        /// <returns>
        /// A negative integer if the current object is less than the other object,
        /// zero if the current object is equal to the other object,
        /// and a positive integer if the current object is greater than the other object.
        /// </returns>
        public int CompareTo(Loot other)
        {
            if (other == null)
            {
                return 1;
            }

            int kindComparison = Kind.CompareTo(other.Kind);
            if (kindComparison!= 0)
            {
                return kindComparison;
            }

            int valueComparison = Value.CompareTo(other.Value);
            if (valueComparison!= 0)
            {
                return valueComparison;
            }

            return Description.CompareTo(other.Description);
        }
    }
}