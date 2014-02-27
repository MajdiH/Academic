using Aterlier;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using AtelierLib;

namespace AtelierTest
{
    
    
    /// <summary>
    ///Classe de test pour RankingTest, destinée à contenir tous
    ///les tests unitaires RankingTest
    ///</summary>
    [TestClass()]
    public class RankingTest
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


        /// <summary>
        ///Test pour Constructeur Ranking
        ///</summary>
        [TestMethod()]
        public void RankingConstructorTest()
        {
            PointSystem system = null; // TODO: initialisez à une valeur appropriée
            Club[] clubs = null; // TODO: initialisez à une valeur appropriée
            Ranking target = new Ranking(system, clubs);
            Assert.Inconclusive("TODO: implémentez le code pour vérifier la cible");
        }

        /// <summary>
        ///Test pour EntryFormClub
        ///</summary>
        [TestMethod()]
        public void EntryFormClubTest()
        {
            PointSystem system = null; // TODO: initialisez à une valeur appropriée
            Club[] clubs = null; // TODO: initialisez à une valeur appropriée
            Ranking target = new Ranking(system, clubs); // TODO: initialisez à une valeur appropriée
            Club c = null; // TODO: initialisez à une valeur appropriée
            Ranking.RankingEntry expected = null; // TODO: initialisez à une valeur appropriée
            Ranking.RankingEntry actual;
            actual = target.EntryFormClub(c);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }

        /// <summary>
        ///Test pour GetClub
        ///</summary>
        [TestMethod()]
        public void GetClubTest()
        {
            PointSystem system = null; // TODO: initialisez à une valeur appropriée
            Club[] clubs = null; // TODO: initialisez à une valeur appropriée
            Ranking target = new Ranking(system, clubs); // TODO: initialisez à une valeur appropriée
            int index = 0; // TODO: initialisez à une valeur appropriée
            Club expected = null; // TODO: initialisez à une valeur appropriée
            Club actual;
            actual = target.GetClub(index);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }

        /// <summary>
        ///Test pour GetPoints
        ///</summary>
        [TestMethod()]
        public void GetPointsTest()
        {
            PointSystem system = null; // TODO: initialisez à une valeur appropriée
            Club[] clubs = null; // TODO: initialisez à une valeur appropriée
            Ranking target = new Ranking(system, clubs); // TODO: initialisez à une valeur appropriée
            int index = 0; // TODO: initialisez à une valeur appropriée
            PointSystem.ITotal expected = null; // TODO: initialisez à une valeur appropriée
            PointSystem.ITotal actual;
            actual = target.GetPoints(index);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }

        /// <summary>
        ///Test pour GetPoints
        ///</summary>
        [TestMethod()]
        public void GetPointsTest1()
        {
            PointSystem system = null; // TODO: initialisez à une valeur appropriée
            Club[] clubs = null; // TODO: initialisez à une valeur appropriée
            Ranking target = new Ranking(system, clubs); // TODO: initialisez à une valeur appropriée
            Club club = null; // TODO: initialisez à une valeur appropriée
            PointSystem.ITotal expected = null; // TODO: initialisez à une valeur appropriée
            PointSystem.ITotal actual;
            actual = target.GetPoints(club);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }

        /// <summary>
        ///Test pour Register
        ///</summary>
        [TestMethod()]
        public void RegisterTest()
        {
            PointSystem system = null; // TODO: initialisez à une valeur appropriée
            Club[] clubs = null; // TODO: initialisez à une valeur appropriée
            Ranking target = new Ranking(system, clubs); // TODO: initialisez à une valeur appropriée
            Match m = null; // TODO: initialisez à une valeur appropriée
            target.Register(m);
            Assert.Inconclusive("Une méthode qui ne retourne pas une valeur ne peut pas être vérifiée.");
        }
    }
}
