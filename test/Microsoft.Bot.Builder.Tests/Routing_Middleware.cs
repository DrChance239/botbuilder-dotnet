﻿using Microsoft.Bot.Builder.Prague;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Bot.Builder.Tests
{
    [TestClass]
    public class Routing_Middleware
    {
        [TestMethod]
        [TestCategory("Middleware")]
        [TestCategory("Routing - Basic")]
        public async Task MiddlwareRouting_SimpleRoute()
        {
            var engine = new ActivityRoutingMiddleware(
                new SimpleRouter((context) => context.Reply("routed")));

            TestConnector connector = new TestConnector();
            Bot bot = new Bot(connector)
                .Use(engine);

            await connector.Say("test", "routed")
                .StartTest();
        }

        [TestMethod]
        [TestCategory("Middleware")]
        [TestCategory("Routing - Basic")]
        public async Task MiddlwareRouting_EvaluteOnlyFirstRule()
        {
            var engine = new ActivityRoutingMiddleware(
                new FirstRouter()
                    .Add(new SimpleRouter((context) => context.Reply("routed")))
                    .Add(new ErrorRouter())
                );

            TestConnector connector = new TestConnector();
            Bot bot = new Bot(connector)
                .Use(engine);

            await connector
                .Say("test", "routed")
                .StartTest();
        }

        [TestMethod]
        [TestCategory("Middleware")]
        [TestCategory("Routing - Basic")]
        public async Task MiddlwareRouting_SkipRule()
        {
            var engine = new ActivityRoutingMiddleware(
                new FirstRouter()
                    .Add(new IfMatch((context) => false, new ErrorRouter()))
                    .Add(new SimpleRouter((context) => context.Reply("routed")))
                    .Add(new ErrorRouter())
                );

            TestConnector connector = new TestConnector();
            Bot bot = new Bot(connector)
                .Use(engine);

            await connector.Say("test", "routed")
                .StartTest();
        }

        [TestMethod]
        [TestCategory("Middleware")]
        [TestCategory("Routing - Basic")]
        public async Task MiddlwareRouting_MatchOnElseCase()
        {
            var engine = new ActivityRoutingMiddleware(
                new FirstRouter()
                    .Add(
                        new IfMatch(
                            (context) => false,
                            new ErrorRouter(),
                            new SimpleRouter((context) => context.Reply("routed"))
                            ))
                );

            TestConnector connector = new TestConnector();
            Bot bot = new Bot(connector)
                .Use(engine);

            await connector.Say("test", "routed")
                .StartTest();
        }
    }
}
