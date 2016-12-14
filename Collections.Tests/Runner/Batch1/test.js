Bridge.assembly("Bridge_Collections_ClientTest_Tests", function ($asm, globals) {
    

    Bridge.define("Bridge.Test.QUnit.Bridge_Collections_ClientTest_Tests_Runner", {
        $main: function () {
            QUnit.module("Bridge Issues");
            QUnit.test("#634 - TestUseCase1", Bridge.Test.QUnit.Bridge_Collections_ClientTest_Tests_Runner.Bridge_Collections_ClientTest_BridgeIssues_Bridge634.testUseCase1);
            QUnit.module("Collections");
            QUnit.test("Queue - TypePropertiesAreCorrect", Bridge.Test.QUnit.Bridge_Collections_ClientTest_Tests_Runner.Bridge_Collections_ClientTest_Collections_Generic_QueueTests.typePropertiesAreCorrect);
            QUnit.test("Queue - CountWorks", Bridge.Test.QUnit.Bridge_Collections_ClientTest_Tests_Runner.Bridge_Collections_ClientTest_Collections_Generic_QueueTests.countWorks);
            QUnit.test("Queue - EnqueueAndDequeueWork", Bridge.Test.QUnit.Bridge_Collections_ClientTest_Tests_Runner.Bridge_Collections_ClientTest_Collections_Generic_QueueTests.enqueueAndDequeueWork);
            QUnit.test("Queue - PeekWorks", Bridge.Test.QUnit.Bridge_Collections_ClientTest_Tests_Runner.Bridge_Collections_ClientTest_Collections_Generic_QueueTests.peekWorks);
            QUnit.test("Queue - ContainsWorks", Bridge.Test.QUnit.Bridge_Collections_ClientTest_Tests_Runner.Bridge_Collections_ClientTest_Collections_Generic_QueueTests.containsWorks);
            QUnit.test("Queue - ContainsUsesEqualsMethod", Bridge.Test.QUnit.Bridge_Collections_ClientTest_Tests_Runner.Bridge_Collections_ClientTest_Collections_Generic_QueueTests.containsUsesEqualsMethod);
            QUnit.test("Queue - ClearWorks", Bridge.Test.QUnit.Bridge_Collections_ClientTest_Tests_Runner.Bridge_Collections_ClientTest_Collections_Generic_QueueTests.clearWorks);
            QUnit.test("Stack - TypePropertiesAreCorrect", Bridge.Test.QUnit.Bridge_Collections_ClientTest_Tests_Runner.Bridge_Collections_ClientTest_Collections_Generic_StackTests.typePropertiesAreCorrect);
            QUnit.test("Stack - DefaultConstructorWorks", Bridge.Test.QUnit.Bridge_Collections_ClientTest_Tests_Runner.Bridge_Collections_ClientTest_Collections_Generic_StackTests.defaultConstructorWorks);
            QUnit.test("Stack - ConstructorWithCapacityWorks", Bridge.Test.QUnit.Bridge_Collections_ClientTest_Tests_Runner.Bridge_Collections_ClientTest_Collections_Generic_StackTests.constructorWithCapacityWorks);
            QUnit.test("Stack - ConstructingFromArrayWorks", Bridge.Test.QUnit.Bridge_Collections_ClientTest_Tests_Runner.Bridge_Collections_ClientTest_Collections_Generic_StackTests.constructingFromArrayWorks);
            QUnit.test("Stack - ConstructingFromListWorks", Bridge.Test.QUnit.Bridge_Collections_ClientTest_Tests_Runner.Bridge_Collections_ClientTest_Collections_Generic_StackTests.constructingFromListWorks);
            QUnit.test("Stack - ConstructingFromIEnumerableWorks", Bridge.Test.QUnit.Bridge_Collections_ClientTest_Tests_Runner.Bridge_Collections_ClientTest_Collections_Generic_StackTests.constructingFromIEnumerableWorks);
            QUnit.test("Stack - CountWorks", Bridge.Test.QUnit.Bridge_Collections_ClientTest_Tests_Runner.Bridge_Collections_ClientTest_Collections_Generic_StackTests.countWorks);
            QUnit.test("Stack - ForeachWorks", Bridge.Test.QUnit.Bridge_Collections_ClientTest_Tests_Runner.Bridge_Collections_ClientTest_Collections_Generic_StackTests.foreachWorks);
            QUnit.test("Stack - PushWorks", Bridge.Test.QUnit.Bridge_Collections_ClientTest_Tests_Runner.Bridge_Collections_ClientTest_Collections_Generic_StackTests.pushWorks);
            QUnit.test("Stack - ClearWorks", Bridge.Test.QUnit.Bridge_Collections_ClientTest_Tests_Runner.Bridge_Collections_ClientTest_Collections_Generic_StackTests.clearWorks);
            QUnit.test("Stack - ContainsWorks", Bridge.Test.QUnit.Bridge_Collections_ClientTest_Tests_Runner.Bridge_Collections_ClientTest_Collections_Generic_StackTests.containsWorks);
            QUnit.test("Stack - ContainsUsesEqualsMethod", Bridge.Test.QUnit.Bridge_Collections_ClientTest_Tests_Runner.Bridge_Collections_ClientTest_Collections_Generic_StackTests.containsUsesEqualsMethod);
            QUnit.test("Stack - ForeachWithListItemCallbackWorks", Bridge.Test.QUnit.Bridge_Collections_ClientTest_Tests_Runner.Bridge_Collections_ClientTest_Collections_Generic_StackTests.foreachWithListItemCallbackWorks);
            QUnit.test("Stack - ForeachWithListCallbackWorks", Bridge.Test.QUnit.Bridge_Collections_ClientTest_Tests_Runner.Bridge_Collections_ClientTest_Collections_Generic_StackTests.foreachWithListCallbackWorks);
            QUnit.test("Stack - PopWorks", Bridge.Test.QUnit.Bridge_Collections_ClientTest_Tests_Runner.Bridge_Collections_ClientTest_Collections_Generic_StackTests.popWorks);
            QUnit.test("Stack - PeekWorks", Bridge.Test.QUnit.Bridge_Collections_ClientTest_Tests_Runner.Bridge_Collections_ClientTest_Collections_Generic_StackTests.peekWorks);
            QUnit.test("Stack - ToArrayWorks", Bridge.Test.QUnit.Bridge_Collections_ClientTest_Tests_Runner.Bridge_Collections_ClientTest_Collections_Generic_StackTests.toArrayWorks);
        }
    });

    Bridge.define("Bridge.Test.QUnit.Bridge_Collections_ClientTest_Tests_Runner.Bridge_Collections_ClientTest_BridgeIssues_Bridge634", {
        inherits: [Bridge.Test.QUnit.TestFixture$1(Bridge.Collections.ClientTest.BridgeIssues.Bridge634)],
        statics: {
            testUseCase1: function (assert) {
                var t = Bridge.Test.QUnit.TestFixture$1(Bridge.Collections.ClientTest.BridgeIssues.Bridge634).beforeTest(false, assert, Bridge.Test.QUnit.Bridge_Collections_ClientTest_Tests_Runner.Bridge_Collections_ClientTest_BridgeIssues_Bridge634, 1, Bridge.merge(new Bridge.Test.QUnit.TestContext(), {
                    method: "TestUseCase1()",
                    line: "12"
                } ));
                Bridge.Collections.ClientTest.BridgeIssues.Bridge634.testUseCase1();
            }
        },
        context: null,
        getContext: function () {
            if (this.context == null) {
                this.context = Bridge.merge(new Bridge.Test.QUnit.FixtureContext(), {
                    project: "Batch1",
                    className: "Bridge.Collections.ClientTest.BridgeIssues.Bridge634",
                    file: "Batch1\\BridgeIssues\\0600\\N634.cs"
                } );
            }
            return this.context;
        }
    });

    Bridge.define("Bridge.Test.QUnit.Bridge_Collections_ClientTest_Tests_Runner.Bridge_Collections_ClientTest_Collections_Generic_QueueTests", {
        inherits: [Bridge.Test.QUnit.TestFixture$1(Bridge.Collections.ClientTest.Collections.Generic.QueueTests)],
        statics: {
            typePropertiesAreCorrect: function (assert) {
                var t = Bridge.Test.QUnit.TestFixture$1(Bridge.Collections.ClientTest.Collections.Generic.QueueTests).beforeTest(true, assert, Bridge.Test.QUnit.Bridge_Collections_ClientTest_Tests_Runner.Bridge_Collections_ClientTest_Collections_Generic_QueueTests, void 0, Bridge.merge(new Bridge.Test.QUnit.TestContext(), {
                    method: "TypePropertiesAreCorrect()",
                    line: "31"
                } ));
                t.getFixture().typePropertiesAreCorrect();
            },
            countWorks: function (assert) {
                var t = Bridge.Test.QUnit.TestFixture$1(Bridge.Collections.ClientTest.Collections.Generic.QueueTests).beforeTest(true, assert, Bridge.Test.QUnit.Bridge_Collections_ClientTest_Tests_Runner.Bridge_Collections_ClientTest_Collections_Generic_QueueTests, void 0, Bridge.merge(new Bridge.Test.QUnit.TestContext(), {
                    method: "CountWorks()",
                    line: "40"
                } ));
                t.getFixture().countWorks();
            },
            enqueueAndDequeueWork: function (assert) {
                var t = Bridge.Test.QUnit.TestFixture$1(Bridge.Collections.ClientTest.Collections.Generic.QueueTests).beforeTest(true, assert, Bridge.Test.QUnit.Bridge_Collections_ClientTest_Tests_Runner.Bridge_Collections_ClientTest_Collections_Generic_QueueTests, void 0, Bridge.merge(new Bridge.Test.QUnit.TestContext(), {
                    method: "EnqueueAndDequeueWork()",
                    line: "51"
                } ));
                t.getFixture().enqueueAndDequeueWork();
            },
            peekWorks: function (assert) {
                var t = Bridge.Test.QUnit.TestFixture$1(Bridge.Collections.ClientTest.Collections.Generic.QueueTests).beforeTest(true, assert, Bridge.Test.QUnit.Bridge_Collections_ClientTest_Tests_Runner.Bridge_Collections_ClientTest_Collections_Generic_QueueTests, void 0, Bridge.merge(new Bridge.Test.QUnit.TestContext(), {
                    method: "PeekWorks()",
                    line: "63"
                } ));
                t.getFixture().peekWorks();
            },
            containsWorks: function (assert) {
                var t = Bridge.Test.QUnit.TestFixture$1(Bridge.Collections.ClientTest.Collections.Generic.QueueTests).beforeTest(true, assert, Bridge.Test.QUnit.Bridge_Collections_ClientTest_Tests_Runner.Bridge_Collections_ClientTest_Collections_Generic_QueueTests, void 0, Bridge.merge(new Bridge.Test.QUnit.TestContext(), {
                    method: "ContainsWorks()",
                    line: "75"
                } ));
                t.getFixture().containsWorks();
            },
            containsUsesEqualsMethod: function (assert) {
                var t = Bridge.Test.QUnit.TestFixture$1(Bridge.Collections.ClientTest.Collections.Generic.QueueTests).beforeTest(true, assert, Bridge.Test.QUnit.Bridge_Collections_ClientTest_Tests_Runner.Bridge_Collections_ClientTest_Collections_Generic_QueueTests, void 0, Bridge.merge(new Bridge.Test.QUnit.TestContext(), {
                    method: "ContainsUsesEqualsMethod()",
                    line: "87"
                } ));
                t.getFixture().containsUsesEqualsMethod();
            },
            clearWorks: function (assert) {
                var t = Bridge.Test.QUnit.TestFixture$1(Bridge.Collections.ClientTest.Collections.Generic.QueueTests).beforeTest(true, assert, Bridge.Test.QUnit.Bridge_Collections_ClientTest_Tests_Runner.Bridge_Collections_ClientTest_Collections_Generic_QueueTests, void 0, Bridge.merge(new Bridge.Test.QUnit.TestContext(), {
                    method: "ClearWorks()",
                    line: "98"
                } ));
                t.getFixture().clearWorks();
            }
        },
        context: null,
        getContext: function () {
            if (this.context == null) {
                this.context = Bridge.merge(new Bridge.Test.QUnit.FixtureContext(), {
                    project: "Batch1",
                    className: "Bridge.Collections.ClientTest.Collections.Generic.QueueTests",
                    file: "Batch1\\Collections\\Generic\\QueueTests.cs"
                } );
            }
            return this.context;
        }
    });

    Bridge.define("Bridge.Test.QUnit.Bridge_Collections_ClientTest_Tests_Runner.Bridge_Collections_ClientTest_Collections_Generic_StackTests", {
        inherits: [Bridge.Test.QUnit.TestFixture$1(Bridge.Collections.ClientTest.Collections.Generic.StackTests)],
        statics: {
            typePropertiesAreCorrect: function (assert) {
                var t = Bridge.Test.QUnit.TestFixture$1(Bridge.Collections.ClientTest.Collections.Generic.StackTests).beforeTest(true, assert, Bridge.Test.QUnit.Bridge_Collections_ClientTest_Tests_Runner.Bridge_Collections_ClientTest_Collections_Generic_StackTests, void 0, Bridge.merge(new Bridge.Test.QUnit.TestContext(), {
                    method: "TypePropertiesAreCorrect()",
                    line: "50"
                } ));
                t.getFixture().typePropertiesAreCorrect();
            },
            defaultConstructorWorks: function (assert) {
                var t = Bridge.Test.QUnit.TestFixture$1(Bridge.Collections.ClientTest.Collections.Generic.StackTests).beforeTest(true, assert, Bridge.Test.QUnit.Bridge_Collections_ClientTest_Tests_Runner.Bridge_Collections_ClientTest_Collections_Generic_StackTests, void 0, Bridge.merge(new Bridge.Test.QUnit.TestContext(), {
                    method: "DefaultConstructorWorks()",
                    line: "60"
                } ));
                t.getFixture().defaultConstructorWorks();
            },
            constructorWithCapacityWorks: function (assert) {
                var t = Bridge.Test.QUnit.TestFixture$1(Bridge.Collections.ClientTest.Collections.Generic.StackTests).beforeTest(true, assert, Bridge.Test.QUnit.Bridge_Collections_ClientTest_Tests_Runner.Bridge_Collections_ClientTest_Collections_Generic_StackTests, void 0, Bridge.merge(new Bridge.Test.QUnit.TestContext(), {
                    method: "ConstructorWithCapacityWorks()",
                    line: "67"
                } ));
                t.getFixture().constructorWithCapacityWorks();
            },
            constructingFromArrayWorks: function (assert) {
                var t = Bridge.Test.QUnit.TestFixture$1(Bridge.Collections.ClientTest.Collections.Generic.StackTests).beforeTest(true, assert, Bridge.Test.QUnit.Bridge_Collections_ClientTest_Tests_Runner.Bridge_Collections_ClientTest_Collections_Generic_StackTests, void 0, Bridge.merge(new Bridge.Test.QUnit.TestContext(), {
                    method: "ConstructingFromArrayWorks()",
                    line: "74"
                } ));
                t.getFixture().constructingFromArrayWorks();
            },
            constructingFromListWorks: function (assert) {
                var t = Bridge.Test.QUnit.TestFixture$1(Bridge.Collections.ClientTest.Collections.Generic.StackTests).beforeTest(true, assert, Bridge.Test.QUnit.Bridge_Collections_ClientTest_Tests_Runner.Bridge_Collections_ClientTest_Collections_Generic_StackTests, void 0, Bridge.merge(new Bridge.Test.QUnit.TestContext(), {
                    method: "ConstructingFromListWorks()",
                    line: "83"
                } ));
                t.getFixture().constructingFromListWorks();
            },
            constructingFromIEnumerableWorks: function (assert) {
                var t = Bridge.Test.QUnit.TestFixture$1(Bridge.Collections.ClientTest.Collections.Generic.StackTests).beforeTest(true, assert, Bridge.Test.QUnit.Bridge_Collections_ClientTest_Tests_Runner.Bridge_Collections_ClientTest_Collections_Generic_StackTests, void 0, Bridge.merge(new Bridge.Test.QUnit.TestContext(), {
                    method: "ConstructingFromIEnumerableWorks()",
                    line: "92"
                } ));
                t.getFixture().constructingFromIEnumerableWorks();
            },
            countWorks: function (assert) {
                var t = Bridge.Test.QUnit.TestFixture$1(Bridge.Collections.ClientTest.Collections.Generic.StackTests).beforeTest(true, assert, Bridge.Test.QUnit.Bridge_Collections_ClientTest_Tests_Runner.Bridge_Collections_ClientTest_Collections_Generic_StackTests, void 0, Bridge.merge(new Bridge.Test.QUnit.TestContext(), {
                    method: "CountWorks()",
                    line: "101"
                } ));
                t.getFixture().countWorks();
            },
            foreachWorks: function (assert) {
                var t = Bridge.Test.QUnit.TestFixture$1(Bridge.Collections.ClientTest.Collections.Generic.StackTests).beforeTest(true, assert, Bridge.Test.QUnit.Bridge_Collections_ClientTest_Tests_Runner.Bridge_Collections_ClientTest_Collections_Generic_StackTests, void 0, Bridge.merge(new Bridge.Test.QUnit.TestContext(), {
                    method: "ForeachWorks()",
                    line: "109"
                } ));
                t.getFixture().foreachWorks();
            },
            pushWorks: function (assert) {
                var t = Bridge.Test.QUnit.TestFixture$1(Bridge.Collections.ClientTest.Collections.Generic.StackTests).beforeTest(true, assert, Bridge.Test.QUnit.Bridge_Collections_ClientTest_Tests_Runner.Bridge_Collections_ClientTest_Collections_Generic_StackTests, void 0, Bridge.merge(new Bridge.Test.QUnit.TestContext(), {
                    method: "PushWorks()",
                    line: "131"
                } ));
                t.getFixture().pushWorks();
            },
            clearWorks: function (assert) {
                var t = Bridge.Test.QUnit.TestFixture$1(Bridge.Collections.ClientTest.Collections.Generic.StackTests).beforeTest(true, assert, Bridge.Test.QUnit.Bridge_Collections_ClientTest_Tests_Runner.Bridge_Collections_ClientTest_Collections_Generic_StackTests, void 0, Bridge.merge(new Bridge.Test.QUnit.TestContext(), {
                    method: "ClearWorks()",
                    line: "139"
                } ));
                t.getFixture().clearWorks();
            },
            containsWorks: function (assert) {
                var t = Bridge.Test.QUnit.TestFixture$1(Bridge.Collections.ClientTest.Collections.Generic.StackTests).beforeTest(true, assert, Bridge.Test.QUnit.Bridge_Collections_ClientTest_Tests_Runner.Bridge_Collections_ClientTest_Collections_Generic_StackTests, void 0, Bridge.merge(new Bridge.Test.QUnit.TestContext(), {
                    method: "ContainsWorks()",
                    line: "147"
                } ));
                t.getFixture().containsWorks();
            },
            containsUsesEqualsMethod: function (assert) {
                var t = Bridge.Test.QUnit.TestFixture$1(Bridge.Collections.ClientTest.Collections.Generic.StackTests).beforeTest(true, assert, Bridge.Test.QUnit.Bridge_Collections_ClientTest_Tests_Runner.Bridge_Collections_ClientTest_Collections_Generic_StackTests, void 0, Bridge.merge(new Bridge.Test.QUnit.TestContext(), {
                    method: "ContainsUsesEqualsMethod()",
                    line: "155"
                } ));
                t.getFixture().containsUsesEqualsMethod();
            },
            foreachWithListItemCallbackWorks: function (assert) {
                var t = Bridge.Test.QUnit.TestFixture$1(Bridge.Collections.ClientTest.Collections.Generic.StackTests).beforeTest(true, assert, Bridge.Test.QUnit.Bridge_Collections_ClientTest_Tests_Runner.Bridge_Collections_ClientTest_Collections_Generic_StackTests, void 0, Bridge.merge(new Bridge.Test.QUnit.TestContext(), {
                    method: "ForeachWithListItemCallbackWorks()",
                    line: "163"
                } ));
                t.getFixture().foreachWithListItemCallbackWorks();
            },
            foreachWithListCallbackWorks: function (assert) {
                var t = Bridge.Test.QUnit.TestFixture$1(Bridge.Collections.ClientTest.Collections.Generic.StackTests).beforeTest(true, assert, Bridge.Test.QUnit.Bridge_Collections_ClientTest_Tests_Runner.Bridge_Collections_ClientTest_Collections_Generic_StackTests, void 0, Bridge.merge(new Bridge.Test.QUnit.TestContext(), {
                    method: "ForeachWithListCallbackWorks()",
                    line: "171"
                } ));
                t.getFixture().foreachWithListCallbackWorks();
            },
            popWorks: function (assert) {
                var t = Bridge.Test.QUnit.TestFixture$1(Bridge.Collections.ClientTest.Collections.Generic.StackTests).beforeTest(true, assert, Bridge.Test.QUnit.Bridge_Collections_ClientTest_Tests_Runner.Bridge_Collections_ClientTest_Collections_Generic_StackTests, void 0, Bridge.merge(new Bridge.Test.QUnit.TestContext(), {
                    method: "PopWorks()",
                    line: "179"
                } ));
                t.getFixture().popWorks();
            },
            peekWorks: function (assert) {
                var t = Bridge.Test.QUnit.TestFixture$1(Bridge.Collections.ClientTest.Collections.Generic.StackTests).beforeTest(true, assert, Bridge.Test.QUnit.Bridge_Collections_ClientTest_Tests_Runner.Bridge_Collections_ClientTest_Collections_Generic_StackTests, void 0, Bridge.merge(new Bridge.Test.QUnit.TestContext(), {
                    method: "PeekWorks()",
                    line: "187"
                } ));
                t.getFixture().peekWorks();
            },
            toArrayWorks: function (assert) {
                var t = Bridge.Test.QUnit.TestFixture$1(Bridge.Collections.ClientTest.Collections.Generic.StackTests).beforeTest(true, assert, Bridge.Test.QUnit.Bridge_Collections_ClientTest_Tests_Runner.Bridge_Collections_ClientTest_Collections_Generic_StackTests, void 0, Bridge.merge(new Bridge.Test.QUnit.TestContext(), {
                    method: "ToArrayWorks()",
                    line: "195"
                } ));
                t.getFixture().toArrayWorks();
            }
        },
        context: null,
        getContext: function () {
            if (this.context == null) {
                this.context = Bridge.merge(new Bridge.Test.QUnit.FixtureContext(), {
                    project: "Batch1",
                    className: "Bridge.Collections.ClientTest.Collections.Generic.StackTests",
                    file: "Batch1\\Collections\\Generic\\StackTests.cs"
                } );
            }
            return this.context;
        }
    });
});
