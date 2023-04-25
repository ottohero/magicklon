using System.Collections;
using System.Collections.Generic;

using NUnit.Framework;

using UnityEngine;
using UnityEngine.TestTools;

namespace Tests {
    public class CardLogicTests {
        // A Test behaves as an ordinary method
        [Test]
        public void CardLogicTestsSimplePasses() {
            // Use the Assert class to test conditions
        }

        [Test]
        public void GameStateTests() {
            GameState gameState = new GameState(1);

            Player player = gameState.Players[0];

            Card testCard = new Card(player, "Ornithopter", new ManaCost(), null, null, null, null);
            Debug.Log(testCard);

            testCard = new Card(player,
                "Tim",
                new ManaCost(new Mana(0, 1, 3, 4, 1, 5)),
                new CardTypes(null, new List<CardType>() { CardType.Creature }, new List<CreatureType>() { CreatureType.Wizard }, null),
                abilities: null,
                basePower: 0,
                baseToughness: 1);
            Debug.Log(testCard);

            Permanent testPermanent = new Permanent(player, player, testCard);
            Debug.Log(testPermanent);
        }

        [Test]
        public void CopyTests() {
            GameState gameState = new GameState(1);

            Player player = gameState.Players[0];
            Card testCard = new Card(player, "Ornithopter", new ManaCost(), null, null, null, null);

            Permanent testPermanent = new Permanent(player, player, testCard);

            gameState.Battlefield.ZoneList.Add(testPermanent);

            GameState copy = gameState.Copy();

            RulesObject ornithopter = gameState.Battlefield.ZoneList.Find((RulesObject ro) => { return ro.Name == "Ornithopter"; });
            ornithopter.Name = "Birds of Paradise";

            List<string> names = new List<string>();

            gameState.Battlefield.ZoneList.ForEach((RulesObject ro) => { Debug.Log(ro.Name); names.Add(ro.Name); });
            copy.Battlefield.ZoneList.ForEach((RulesObject ro) => { Debug.Log(ro.Name); names.Add(ro.Name); });

            StringAssert.AreNotEqualIgnoringCase(names[0], names[1]);
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator CardLogicTestsWithEnumeratorPasses() {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}
