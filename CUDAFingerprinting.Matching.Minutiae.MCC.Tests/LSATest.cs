﻿using CUDAFingerprinting.Matching.Minutiae.MCC;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CUDAFingerprinting.Matching.Minutiae.MCC.Tests
{
    
    
    /// <summary>
    ///Это класс теста для LSATest, в котором должны
    ///находиться все модульные тесты LSATest
    ///</summary>
    [TestClass()]
    public class LSATest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Получает или устанавливает контекст теста, в котором предоставляются
        ///сведения о текущем тестовом запуске и обеспечивается его функциональность.
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

        #region Дополнительные атрибуты теста
        // 
        //При написании тестов можно использовать следующие дополнительные атрибуты:
        //
        //ClassInitialize используется для выполнения кода до запуска первого теста в классе
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //ClassCleanup используется для выполнения кода после завершения работы всех тестов в классе
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //TestInitialize используется для выполнения кода перед запуском каждого теста
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //TestCleanup используется для выполнения кода после завершения каждого теста
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///Тест для GetScore
        ///</summary>
        [TestMethod()]
        public void GetScoreTest()
        {
            double[,] Gamma = new double[2, 2]  {{4,4},{8,5}}; // TODO: инициализация подходящего значения
            int np = 3; // TODO: инициализация подходящего значения
            double expected = 0; // TODO: инициализация подходящего значения
            double actual = LSA.GetScore(Gamma, np);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }
    }
}