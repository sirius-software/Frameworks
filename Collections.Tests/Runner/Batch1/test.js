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
                var t = Bridge.Test.QUnit.TestFixture$1(Bridge.Collections.ClientTest.BridgeIssues.Bridge634).beforeTest(false, assert, Bridge.Test.QUnit.Bridge_Collections_ClientTest_Tests_Runner.Bridge_Collections_ClientTest_BridgeIssues_Bridge634, 1);
                Bridge.Collections.ClientTest.BridgeIssues.Bridge634.testUseCase1();
            }
        }
    });

    Bridge.define("Bridge.Test.QUnit.Bridge_Collections_ClientTest_Tests_Runner.Bridge_Collections_ClientTest_Collections_Generic_QueueTests", {
        inherits: [Bridge.Test.QUnit.TestFixture$1(Bridge.Collections.ClientTest.Collections.Generic.QueueTests)],
        statics: {
            typePropertiesAreCorrect: function (assert) {
                var t = Bridge.Test.QUnit.TestFixture$1(Bridge.Collections.ClientTest.Collections.Generic.QueueTests).beforeTest(true, assert, Bridge.Test.QUnit.Bridge_Collections_ClientTest_Tests_Runner.Bridge_Collections_ClientTest_Collections_Generic_QueueTests);
                t.getFixture().typePropertiesAreCorrect();
            },
            countWorks: function (assert) {
                var t = Bridge.Test.QUnit.TestFixture$1(Bridge.Collections.ClientTest.Collections.Generic.QueueTests).beforeTest(true, assert, Bridge.Test.QUnit.Bridge_Collections_ClientTest_Tests_Runner.Bridge_Collections_ClientTest_Collections_Generic_QueueTests);
                t.getFixture().countWorks();
            },
            enqueueAndDequeueWork: function (assert) {
                var t = Bridge.Test.QUnit.TestFixture$1(Bridge.Collections.ClientTest.Collections.Generic.QueueTests).beforeTest(true, assert, Bridge.Test.QUnit.Bridge_Collections_ClientTest_Tests_Runner.Bridge_Collections_ClientTest_Collections_Generic_QueueTests);
                t.getFixture().enqueueAndDequeueWork();
            },
            peekWorks: function (assert) {
                var t = Bridge.Test.QUnit.TestFixture$1(Bridge.Collections.ClientTest.Collections.Generic.QueueTests).beforeTest(true, assert, Bridge.Test.QUnit.Bridge_Collections_ClientTest_Tests_Runner.Bridge_Collections_ClientTest_Collections_Generic_QueueTests);
                t.getFixture().peekWorks();
            },
            containsWorks: function (assert) {
                var t = Bridge.Test.QUnit.TestFixture$1(Bridge.Collections.ClientTest.Collections.Generic.QueueTests).beforeTest(true, assert, Bridge.Test.QUnit.Bridge_Collections_ClientTest_Tests_Runner.Bridge_Collections_ClientTest_Collections_Generic_QueueTests);
                t.getFixture().containsWorks();
            },
            containsUsesEqualsMethod: function (assert) {
                var t = Bridge.Test.QUnit.TestFixture$1(Bridge.Collections.ClientTest.Collections.Generic.QueueTests).beforeTest(true, assert, Bridge.Test.QUnit.Bridge_Collections_ClientTest_Tests_Runner.Bridge_Collections_ClientTest_Collections_Generic_QueueTests);
                t.getFixture().containsUsesEqualsMethod();
            },
            clearWorks: function (assert) {
                var t = Bridge.Test.QUnit.TestFixture$1(Bridge.Collections.ClientTest.Collections.Generic.QueueTests).beforeTest(true, assert, Bridge.Test.QUnit.Bridge_Collections_ClientTest_Tests_Runner.Bridge_Collections_ClientTest_Collections_Generic_QueueTests);
                t.getFixture().clearWorks();
            }
        }
    });

    Bridge.define("Bridge.Test.QUnit.Bridge_Collections_ClientTest_Tests_Runner.Bridge_Collections_ClientTest_Collections_Generic_StackTests", {
        inherits: [Bridge.Test.QUnit.TestFixture$1(Bridge.Collections.ClientTest.Collections.Generic.StackTests)],
        statics: {
            typePropertiesAreCorrect: function (assert) {
                var t = Bridge.Test.QUnit.TestFixture$1(Bridge.Collections.ClientTest.Collections.Generic.StackTests).beforeTest(true, assert, Bridge.Test.QUnit.Bridge_Collections_ClientTest_Tests_Runner.Bridge_Collections_ClientTest_Collections_Generic_StackTests);
                t.getFixture().typePropertiesAreCorrect();
            },
            defaultConstructorWorks: function (assert) {
                var t = Bridge.Test.QUnit.TestFixture$1(Bridge.Collections.ClientTest.Collections.Generic.StackTests).beforeTest(true, assert, Bridge.Test.QUnit.Bridge_Collections_ClientTest_Tests_Runner.Bridge_Collections_ClientTest_Collections_Generic_StackTests);
                t.getFixture().defaultConstructorWorks();
            },
            constructorWithCapacityWorks: function (assert) {
                var t = Bridge.Test.QUnit.TestFixture$1(Bridge.Collections.ClientTest.Collections.Generic.StackTests).beforeTest(true, assert, Bridge.Test.QUnit.Bridge_Collections_ClientTest_Tests_Runner.Bridge_Collections_ClientTest_Collections_Generic_StackTests);
                t.getFixture().constructorWithCapacityWorks();
            },
            constructingFromArrayWorks: function (assert) {
                var t = Bridge.Test.QUnit.TestFixture$1(Bridge.Collections.ClientTest.Collections.Generic.StackTests).beforeTest(true, assert, Bridge.Test.QUnit.Bridge_Collections_ClientTest_Tests_Runner.Bridge_Collections_ClientTest_Collections_Generic_StackTests);
                t.getFixture().constructingFromArrayWorks();
            },
            constructingFromListWorks: function (assert) {
                var t = Bridge.Test.QUnit.TestFixture$1(Bridge.Collections.ClientTest.Collections.Generic.StackTests).beforeTest(true, assert, Bridge.Test.QUnit.Bridge_Collections_ClientTest_Tests_Runner.Bridge_Collections_ClientTest_Collections_Generic_StackTests);
                t.getFixture().constructingFromListWorks();
            },
            constructingFromIEnumerableWorks: function (assert) {
                var t = Bridge.Test.QUnit.TestFixture$1(Bridge.Collections.ClientTest.Collections.Generic.StackTests).beforeTest(true, assert, Bridge.Test.QUnit.Bridge_Collections_ClientTest_Tests_Runner.Bridge_Collections_ClientTest_Collections_Generic_StackTests);
                t.getFixture().constructingFromIEnumerableWorks();
            },
            countWorks: function (assert) {
                var t = Bridge.Test.QUnit.TestFixture$1(Bridge.Collections.ClientTest.Collections.Generic.StackTests).beforeTest(true, assert, Bridge.Test.QUnit.Bridge_Collections_ClientTest_Tests_Runner.Bridge_Collections_ClientTest_Collections_Generic_StackTests);
                t.getFixture().countWorks();
            },
            foreachWorks: function (assert) {
                var t = Bridge.Test.QUnit.TestFixture$1(Bridge.Collections.ClientTest.Collections.Generic.StackTests).beforeTest(true, assert, Bridge.Test.QUnit.Bridge_Collections_ClientTest_Tests_Runner.Bridge_Collections_ClientTest_Collections_Generic_StackTests);
                t.getFixture().foreachWorks();
            },
            pushWorks: function (assert) {
                var t = Bridge.Test.QUnit.TestFixture$1(Bridge.Collections.ClientTest.Collections.Generic.StackTests).beforeTest(true, assert, Bridge.Test.QUnit.Bridge_Collections_ClientTest_Tests_Runner.Bridge_Collections_ClientTest_Collections_Generic_StackTests);
                t.getFixture().pushWorks();
            },
            clearWorks: function (assert) {
                var t = Bridge.Test.QUnit.TestFixture$1(Bridge.Collections.ClientTest.Collections.Generic.StackTests).beforeTest(true, assert, Bridge.Test.QUnit.Bridge_Collections_ClientTest_Tests_Runner.Bridge_Collections_ClientTest_Collections_Generic_StackTests);
                t.getFixture().clearWorks();
            },
            containsWorks: function (assert) {
                var t = Bridge.Test.QUnit.TestFixture$1(Bridge.Collections.ClientTest.Collections.Generic.StackTests).beforeTest(true, assert, Bridge.Test.QUnit.Bridge_Collections_ClientTest_Tests_Runner.Bridge_Collections_ClientTest_Collections_Generic_StackTests);
                t.getFixture().containsWorks();
            },
            containsUsesEqualsMethod: function (assert) {
                var t = Bridge.Test.QUnit.TestFixture$1(Bridge.Collections.ClientTest.Collections.Generic.StackTests).beforeTest(true, assert, Bridge.Test.QUnit.Bridge_Collections_ClientTest_Tests_Runner.Bridge_Collections_ClientTest_Collections_Generic_StackTests);
                t.getFixture().containsUsesEqualsMethod();
            },
            foreachWithListItemCallbackWorks: function (assert) {
                var t = Bridge.Test.QUnit.TestFixture$1(Bridge.Collections.ClientTest.Collections.Generic.StackTests).beforeTest(true, assert, Bridge.Test.QUnit.Bridge_Collections_ClientTest_Tests_Runner.Bridge_Collections_ClientTest_Collections_Generic_StackTests);
                t.getFixture().foreachWithListItemCallbackWorks();
            },
            foreachWithListCallbackWorks: function (assert) {
                var t = Bridge.Test.QUnit.TestFixture$1(Bridge.Collections.ClientTest.Collections.Generic.StackTests).beforeTest(true, assert, Bridge.Test.QUnit.Bridge_Collections_ClientTest_Tests_Runner.Bridge_Collections_ClientTest_Collections_Generic_StackTests);
                t.getFixture().foreachWithListCallbackWorks();
            },
            popWorks: function (assert) {
                var t = Bridge.Test.QUnit.TestFixture$1(Bridge.Collections.ClientTest.Collections.Generic.StackTests).beforeTest(true, assert, Bridge.Test.QUnit.Bridge_Collections_ClientTest_Tests_Runner.Bridge_Collections_ClientTest_Collections_Generic_StackTests);
                t.getFixture().popWorks();
            },
            peekWorks: function (assert) {
                var t = Bridge.Test.QUnit.TestFixture$1(Bridge.Collections.ClientTest.Collections.Generic.StackTests).beforeTest(true, assert, Bridge.Test.QUnit.Bridge_Collections_ClientTest_Tests_Runner.Bridge_Collections_ClientTest_Collections_Generic_StackTests);
                t.getFixture().peekWorks();
            },
            toArrayWorks: function (assert) {
                var t = Bridge.Test.QUnit.TestFixture$1(Bridge.Collections.ClientTest.Collections.Generic.StackTests).beforeTest(true, assert, Bridge.Test.QUnit.Bridge_Collections_ClientTest_Tests_Runner.Bridge_Collections_ClientTest_Collections_Generic_StackTests);
                t.getFixture().toArrayWorks();
            }
        }
    });
});
