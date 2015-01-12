﻿namespace Knapsack
{
    using System.Collections.Generic;
    using System.Linq;

    public abstract class KnapsackSolver
    {
        public KnapsackSolver(IList<Item> items, int capacity)
        {
            this.Items = items;
            this.Capacity = capacity;
        }

        protected IList<Item> Items { get; set; }

        protected int Capacity { get; set; }

        public abstract KnapsackSolution Solve();

        public double getWeight(IList<Item> items)
        {
            return items.Sum(i => i.Weight);
        }

        public double getValue(IList<Item> items)
        {
            return items.Sum(i => i.Value);
        }
    }
}