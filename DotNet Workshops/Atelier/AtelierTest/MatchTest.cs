using AtelierLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AtelierTest
{
    
    
    /// <summary>
    ///Classe de test pour MatchTest, destinée à contenir tous
    ///les tests unitaires MatchTest
    ///</summary>
    [TestClass()]
    public class MatchTest
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


        internal virtual Match CreateMatch()
        {
            // TODO: instanciez une classe concrète appropriée.
            Match target = null;
            return target;
        }

        /// <summary>
        ///Test pour Away
        ///</summary>
        [TestMethod()]
        public void AwayTest()
        {
            Club h = new Club("Barcelone");
            Club a = new Club("Madrid");
            Match target = new Match(h, a, 2, 6);
            Assert.AreEqual(a, target.Away);
        }

        /// <summary>
        ///Test pour AwayGoals
        ///</summary>
        [TestMethod()]
        public void AwayGoalsTest()
        {
            Club h = new Club("Barcelone");
            Club a = new Club("Madrid");
            Match target = new Match(h, a, 2, 6);
            Assert.AreEqual(6, target.AwayGoals);
        }

        /// <summary>
        ///Test pour Home
        ///</summary>
        [TestMethod()]
        public void HomeTest()
        {
            Club h = new Club("Barcelone");
            Club a = new Club("Madrid");
            Match target = new Match(h, a, 2, 6);
            Assert.AreEqual(h, target.Home);
        }

        /// <summary>
        ///Test pour HomeGoals
        ///</summary>
        [TestMethod()]
        public void HomeGoalsTest()
        {
            Club h = new Club("Barcelone");
            Club a = new Club("Madrid");
            Match target = new Match(h, a, 2, 6);
            Assert.AreEqual(2, target.HomeGoals);
        }

        /// <summary>
        ///Test pour isAwayForfait
        ///</summary>
        [TestMethod()]
        public void isAwayForfaitTest()
        {
            Club h = new Club("Barcelone");
            Club a = new Club("Madrid");
            Match target = new Match(h, a, false, true); 
            Assert.AreEqual(true, target.isAwayForfait);
        }

        /// <summary>
        ///Test pour isDraw
        ///</summary>
        [TestMethod()]
        public void isDrawTest()
        {
            Club h = new Club("Barcelone");
            Club a = new Club("Madrid");
            Match target = new Match(h, a, 4, 4);
            Assert.AreEqual(true, target.isDraw);
        }

        /// <summary>
        ///Test pour isHomeForfait
        ///</summary>
        [TestMethod()]
        public void isHomeForfaitTest()
        {
            
            Club h = new Club("Barcelone");
            Club a = new Club("Madrid");
            Match target = new Match(h, a, true, false);
            Assert.AreEqual(true, target.isHomeForfait);
        }
    }
}
