using Aterlier;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using AtelierLib;

namespace AtelierTest
{
    
    
    /// <summary>
    ///Classe de test pour Ranking_RankingEntryTest, destinée à contenir tous
    ///les tests unitaires Ranking_RankingEntryTest
    ///</summary>
    [TestClass()]
    public class Ranking_RankingEntryTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Obtient ou définit le contexte de test qui fournit
        ///des informations sur la série de tests active ainsi que ses fonctionnalités.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Attributs de tests supplémentaires
        // 
        //Vous pouvez utiliser les attributs supplémentaires suivants lorsque vous écrivez vos tests :
        //
        //Utilisez ClassInitialize pour exécuter du code avant d'exécuter le premier test dans la classe
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Utilisez ClassCleanup pour exécuter du code après que tous les tests ont été exécutés dans une classe
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Utilisez TestInitialize pour exécuter du code avant d'exécuter chaque test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Utilisez TestCleanup pour exécuter du code après que chaque test a été exécuté
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        internal virtual Ranking.RankingEntry Create_Ranking_RankingEntry()
        {
            // TODO: instanciez une classe concrète appropriée.
            Ranking.RankingEntry target = null;
            return target;
        }

        /// <summary>
        ///Test pour CompareTo
        ///</summary>
        [TestMethod()]
        public void CompareToTest()
        {
            Ranking.RankingEntry target = Create_Ranking_RankingEntry(); // TODO: initialisez à une valeur appropriée
            object obj = null; // TODO: initialisez à une valeur appropriée
            int expected = 0; // TODO: initialisez à une valeur appropriée
            int actual;
            actual = target.CompareTo(obj);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }

        /// <summary>
        ///Test pour Club
        ///</summary>
        [TestMethod()]
        public void ClubTest()
        {
            Ranking.RankingEntry target = Create_Ranking_RankingEntry(); // TODO: initialisez à une valeur appropriée
            Club actual;
            actual = target.Club;
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }

        /// <summary>
        ///Test pour Points
        ///</summary>
        [TestMethod()]
        public void PointsTest()
        {
            Club c = new Club("Madrid");
            Ranking.RankingEntry target = new Aterlier.Ranking.RankingEntry(c, 85);
            PointSystem.ITotal actual;
            actual = target.Points;
        }
    }
}
