﻿namespace Kata.Rx.Scheduling.Tests
{
    using System;
    using System.Text;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class SchedulerWorkerRoleTest
    {
        public SchedulerWorkerRoleTest() { /* TODO: Add constructor logic here  - NOT!!! */ }

        [TestMethod]
        public void CanPutItemsOnTheQueue()
        {
            // Create/Find a queue
            var purchasedProductQueue = new Queue<Product>();
            
            // Create a reference to the queue

            // Create state objects and add them to the queue

            // Assert.IsTrue(QueueReference.ItemsAreOnQueue)
        }

        [TestMethod]
        public void CanPeekAtItemsOnTheQueue()
        {
            // Create/Find a queue
            var purchasedProductQueue = new Queue<Product>();

            // Create a reference to the queue

            // Create state objects and add them to the queue

            // Assert.IsTrue(QueueReference.PeekAt(thirdItemOnQueue) != null);
        }

        [TestMethod]
        public void CanPopItemsOffTheQueue()
        {
            // Create/Find a queue
            var purchasedProductQueue = new Queue<Product>();

            // Create a reference to the queue

            // Create expected state object and add it to the queue

            // var expectProduct = QueueReference.PukeAt(fourthItemOnQueue);
            
            // Assert.AreEqual(actualProduct, expectedProduct);
        }
    }
}