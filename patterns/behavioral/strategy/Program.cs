using System;

namespace strategy {
    public interface IStrategy {
        void Operation ();
    }

    public class StrategyRight : IStrategy {
        public void Operation () {
            Console.WriteLine ("Right");
        }
    }

    public class StrategyLeft : IStrategy {
        public void Operation () {
            Console.WriteLine ("Left");
        }
    }

    public class ApplyerOperator {
        private IStrategy _strategy;

        public ApplyerOperator (IStrategy strategy) {
            _strategy = strategy;
        }

        public void SetOperator (IStrategy strategy) {
            _strategy = strategy;
        }

        public void ApplyStrategy () {
            _strategy.Operation ();
        }
    }

    class Program {
        static void Main (string[] args) {

            IStrategy rightS = new StrategyRight ();
            ApplyerOperator operators = new ApplyerOperator (rightS);

            operators.ApplyStrategy ();
            operators.SetOperator (new StrategyLeft ());
            operators.ApplyStrategy ();
        }
    }
}