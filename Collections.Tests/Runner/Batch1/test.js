(function (globals) {
    
    Bridge.define('Bridge.Test.Assert', {
        statics: {
            assert: null,
            async: function () {
                return Bridge.Test.Assert.assert.async();
            },
            areEqual: function (expected, actual) {
                Bridge.Test.Assert.assert.deepEqual(actual, expected);
            },
            areEqual$1: function (expected, actual, description) {
                Bridge.Test.Assert.assert.deepEqual(actual, expected, description);
            },
            areDeepEqual: function (expected, actual) {
                Bridge.Test.Assert.assert.deepEqual(actual, expected);
            },
            areDeepEqual$1: function (expected, actual, description) {
                Bridge.Test.Assert.assert.deepEqual(actual, expected, description);
            },
            areStrictEqual: function (expected, actual) {
                Bridge.Test.Assert.assert.strictEqual(actual, expected);
            },
            areStrictEqual$1: function (expected, actual, description) {
                Bridge.Test.Assert.assert.strictEqual(actual, expected, description);
            },
            areNotEqual: function (expected, actual) {
                Bridge.Test.Assert.assert.notDeepEqual(actual, expected);
            },
            areNotEqual$1: function (expected, actual, description) {
                Bridge.Test.Assert.assert.notDeepEqual(actual, expected, description);
            },
            areNotDeepEqual: function (expected, actual) {
                Bridge.Test.Assert.assert.notDeepEqual(actual, expected);
            },
            areNotDeepEqual$1: function (expected, actual, description) {
                Bridge.Test.Assert.assert.notDeepEqual(actual, expected, description);
            },
            areNotStrictEqual: function (expected, actual) {
                Bridge.Test.Assert.assert.notStrictEqual(actual, expected);
            },
            areNotStrictEqual$1: function (expected, actual, description) {
                Bridge.Test.Assert.assert.notStrictEqual(actual, expected, description);
            },
            true: function (condition) {
                Bridge.Test.Assert.assert.ok(condition);
            },
            true$1: function (condition, message) {
                Bridge.Test.Assert.assert.ok(condition, message);
            },
            false: function (condition) {
                Bridge.Test.Assert.assert.notOk(condition);
            },
            false$1: function (condition, message) {
                Bridge.Test.Assert.assert.notOk(condition, message);
            },
            fail: function () {
                Bridge.Test.Assert.assert.ok(false);
            },
            fail$1: function (message) {
                Bridge.Test.Assert.assert.notOk(true, message);
            },
            throws: function (block) {
                Bridge.Test.Assert.assert.throws(block, "");
            },
            throws$5: function (block, message) {
                Bridge.Test.Assert.assert.throws(block, message);
            },
            throws$6: function (T, block) {
                Bridge.Test.Assert.throws$7(T, block, "");
            },
            throws$7: function (T, block, message) {
                var actual = null;
                var expected = Bridge.getTypeName(T);
    
                try {
                    block();
                }
                catch (ex) {
                    ex = System.Exception.create(ex);
                    actual = Bridge.getTypeName(ex);
                }
    
                if (!Bridge.referenceEquals(actual, expected)) {
                    Bridge.Test.Assert.assert.equal(actual, expected, message);
                }
                else  {
                    Bridge.Test.Assert.assert.ok(true, message);
                }
            },
            throws$3: function (block, expected) {
                Bridge.Test.Assert.assert.throws(block, expected);
            },
            throws$4: function (block, expected, message) {
                Bridge.Test.Assert.assert.throws(block, expected, message);
            },
            throws$1: function (block, expected) {
                Bridge.Test.Assert.assert.throws(block, expected);
            },
            throws$2: function (block, expected, message) {
                Bridge.Test.Assert.assert.throws(block, expected, message);
            },
            null: function (anObject) {
                Bridge.Test.Assert.assert.ok(anObject == null);
            },
            null$1: function (anObject, message) {
                Bridge.Test.Assert.assert.ok(anObject == null, message);
            },
            notNull: function (anObject) {
                Bridge.Test.Assert.assert.notOk(anObject == null);
            },
            notNull$1: function (anObject, message) {
                Bridge.Test.Assert.assert.notOk(anObject == null, message);
            }
        }
    });
    
    Bridge.define('Bridge.Test.QUnit.TestFixture$1', function (T) { return {
        statics: {
            instanceFabric: null,
            fixtureFabric: Bridge.getDefaultValue(T),
            getFixtureFabric: function () {
                if (Bridge.Test.QUnit.TestFixture$1(T).fixtureFabric == null) {
                    Bridge.Test.QUnit.TestFixture$1(T).fixtureFabric = new T();
                }
    
                return Bridge.Test.QUnit.TestFixture$1(T).fixtureFabric;
            },
            setFixtureFabric: function (value) {
                Bridge.Test.QUnit.TestFixture$1(T).fixtureFabric = value;
            },
            instanceFabric$1: function (type) {
                if (Bridge.Test.QUnit.TestFixture$1(T).instanceFabric == null) {
                    Bridge.Test.QUnit.TestFixture$1(T).instanceFabric = Bridge.cast(Bridge.createInstance(type), Bridge.Test.QUnit.TestFixture$1(T));
                }
    
                return Bridge.Test.QUnit.TestFixture$1(T).instanceFabric;
            },
            beforeTest: function (needInstance, assert, type, expectedCount) {
                if (expectedCount === void 0) { expectedCount = null; }
                Bridge.Test.Assert.assert = assert;
    
                if (System.Nullable.hasValue(expectedCount)) {
                    assert.expect(System.Nullable.getValue(expectedCount));
                }
    
                var instance = Bridge.Test.QUnit.TestFixture$1(T).instanceFabric$1(type);
                instance.setFixture(needInstance ? Bridge.Test.QUnit.TestFixture$1(T).getFixtureFabric() : Bridge.getDefaultValue(T));
    
                try {
                    instance.setUp();
                }
                catch ($e1) {
                    $e1 = System.Exception.create($e1);
                    assert.ok(false, "The test failed SetUp");
    
                    throw $e1;
                }
    
                return instance;
            }
        },
        config: {
            properties: {
                Fixture: Bridge.getDefaultValue(T)
            }
        },
        setUp: function () {
        },
        tearDown: function () {
        }
    }; });
    
    Bridge.define('Bridge.Test.QUnit.TestRunner', {
        statics: {
            config: {
                init: function () {
                    Bridge.ready(this.main);
                }
            },
            main: function () {
                QUnit.module("Bridge Issues");
                QUnit.test("#634 - TestUseCase1", Bridge.Test.QUnit.TestRunner.Bridge_Collections_ClientTest_BridgeIssues_Bridge634.testUseCase1);
                QUnit.module("Collections");
                QUnit.test("Stack - TypePropertiesAreCorrect", Bridge.Test.QUnit.TestRunner.Bridge_Collections_ClientTest_Collections_Generic_StackTests.typePropertiesAreCorrect);
                QUnit.test("Stack - DefaultConstructorWorks", Bridge.Test.QUnit.TestRunner.Bridge_Collections_ClientTest_Collections_Generic_StackTests.defaultConstructorWorks);
                QUnit.test("Stack - ConstructorWithCapacityWorks", Bridge.Test.QUnit.TestRunner.Bridge_Collections_ClientTest_Collections_Generic_StackTests.constructorWithCapacityWorks);
                QUnit.test("Stack - ConstructingFromArrayWorks", Bridge.Test.QUnit.TestRunner.Bridge_Collections_ClientTest_Collections_Generic_StackTests.constructingFromArrayWorks);
                QUnit.test("Stack - ConstructingFromListWorks", Bridge.Test.QUnit.TestRunner.Bridge_Collections_ClientTest_Collections_Generic_StackTests.constructingFromListWorks);
                QUnit.test("Stack - ConstructingFromIEnumerableWorks", Bridge.Test.QUnit.TestRunner.Bridge_Collections_ClientTest_Collections_Generic_StackTests.constructingFromIEnumerableWorks);
                QUnit.test("Stack - CountWorks", Bridge.Test.QUnit.TestRunner.Bridge_Collections_ClientTest_Collections_Generic_StackTests.countWorks);
                QUnit.test("Stack - ForeachWorks", Bridge.Test.QUnit.TestRunner.Bridge_Collections_ClientTest_Collections_Generic_StackTests.foreachWorks);
                QUnit.test("Stack - PushWorks", Bridge.Test.QUnit.TestRunner.Bridge_Collections_ClientTest_Collections_Generic_StackTests.pushWorks);
                QUnit.test("Stack - ClearWorks", Bridge.Test.QUnit.TestRunner.Bridge_Collections_ClientTest_Collections_Generic_StackTests.clearWorks);
                QUnit.test("Stack - ContainsWorks", Bridge.Test.QUnit.TestRunner.Bridge_Collections_ClientTest_Collections_Generic_StackTests.containsWorks);
                QUnit.test("Stack - ContainsUsesEqualsMethod", Bridge.Test.QUnit.TestRunner.Bridge_Collections_ClientTest_Collections_Generic_StackTests.containsUsesEqualsMethod);
                QUnit.test("Stack - ForeachWithListItemCallbackWorks", Bridge.Test.QUnit.TestRunner.Bridge_Collections_ClientTest_Collections_Generic_StackTests.foreachWithListItemCallbackWorks);
                QUnit.test("Stack - ForeachWithListCallbackWorks", Bridge.Test.QUnit.TestRunner.Bridge_Collections_ClientTest_Collections_Generic_StackTests.foreachWithListCallbackWorks);
                QUnit.test("Stack - PopWorks", Bridge.Test.QUnit.TestRunner.Bridge_Collections_ClientTest_Collections_Generic_StackTests.popWorks);
                QUnit.test("Stack - PeekWorks", Bridge.Test.QUnit.TestRunner.Bridge_Collections_ClientTest_Collections_Generic_StackTests.peekWorks);
                QUnit.test("Stack - ToArrayWorks", Bridge.Test.QUnit.TestRunner.Bridge_Collections_ClientTest_Collections_Generic_StackTests.toArrayWorks);
            }
        },
        $entryPoint: true
    });
    
    Bridge.define('Bridge.Test.QUnit.TestRunner.Bridge_Collections_ClientTest_BridgeIssues_Bridge634', {
        inherits: [Bridge.Test.QUnit.TestFixture$1(Bridge.Collections.ClientTest.BridgeIssues.Bridge634)],
        statics: {
            testUseCase1: function (assert) {
                var t = Bridge.Test.QUnit.TestFixture$1(Bridge.Collections.ClientTest.BridgeIssues.Bridge634).beforeTest(false, assert, Bridge.Test.QUnit.TestRunner.Bridge_Collections_ClientTest_BridgeIssues_Bridge634, 1);
                Bridge.Collections.ClientTest.BridgeIssues.Bridge634.testUseCase1();
            }
        }
    });
    
    Bridge.define('Bridge.Test.QUnit.TestRunner.Bridge_Collections_ClientTest_Collections_Generic_StackTests', {
        inherits: [Bridge.Test.QUnit.TestFixture$1(Bridge.Collections.ClientTest.Collections.Generic.StackTests)],
        statics: {
            typePropertiesAreCorrect: function (assert) {
                var t = Bridge.Test.QUnit.TestFixture$1(Bridge.Collections.ClientTest.Collections.Generic.StackTests).beforeTest(true, assert, Bridge.Test.QUnit.TestRunner.Bridge_Collections_ClientTest_Collections_Generic_StackTests);
                t.getFixture().typePropertiesAreCorrect();
            },
            defaultConstructorWorks: function (assert) {
                var t = Bridge.Test.QUnit.TestFixture$1(Bridge.Collections.ClientTest.Collections.Generic.StackTests).beforeTest(true, assert, Bridge.Test.QUnit.TestRunner.Bridge_Collections_ClientTest_Collections_Generic_StackTests);
                t.getFixture().defaultConstructorWorks();
            },
            constructorWithCapacityWorks: function (assert) {
                var t = Bridge.Test.QUnit.TestFixture$1(Bridge.Collections.ClientTest.Collections.Generic.StackTests).beforeTest(true, assert, Bridge.Test.QUnit.TestRunner.Bridge_Collections_ClientTest_Collections_Generic_StackTests);
                t.getFixture().constructorWithCapacityWorks();
            },
            constructingFromArrayWorks: function (assert) {
                var t = Bridge.Test.QUnit.TestFixture$1(Bridge.Collections.ClientTest.Collections.Generic.StackTests).beforeTest(true, assert, Bridge.Test.QUnit.TestRunner.Bridge_Collections_ClientTest_Collections_Generic_StackTests);
                t.getFixture().constructingFromArrayWorks();
            },
            constructingFromListWorks: function (assert) {
                var t = Bridge.Test.QUnit.TestFixture$1(Bridge.Collections.ClientTest.Collections.Generic.StackTests).beforeTest(true, assert, Bridge.Test.QUnit.TestRunner.Bridge_Collections_ClientTest_Collections_Generic_StackTests);
                t.getFixture().constructingFromListWorks();
            },
            constructingFromIEnumerableWorks: function (assert) {
                var t = Bridge.Test.QUnit.TestFixture$1(Bridge.Collections.ClientTest.Collections.Generic.StackTests).beforeTest(true, assert, Bridge.Test.QUnit.TestRunner.Bridge_Collections_ClientTest_Collections_Generic_StackTests);
                t.getFixture().constructingFromIEnumerableWorks();
            },
            countWorks: function (assert) {
                var t = Bridge.Test.QUnit.TestFixture$1(Bridge.Collections.ClientTest.Collections.Generic.StackTests).beforeTest(true, assert, Bridge.Test.QUnit.TestRunner.Bridge_Collections_ClientTest_Collections_Generic_StackTests);
                t.getFixture().countWorks();
            },
            foreachWorks: function (assert) {
                var t = Bridge.Test.QUnit.TestFixture$1(Bridge.Collections.ClientTest.Collections.Generic.StackTests).beforeTest(true, assert, Bridge.Test.QUnit.TestRunner.Bridge_Collections_ClientTest_Collections_Generic_StackTests);
                t.getFixture().foreachWorks();
            },
            pushWorks: function (assert) {
                var t = Bridge.Test.QUnit.TestFixture$1(Bridge.Collections.ClientTest.Collections.Generic.StackTests).beforeTest(true, assert, Bridge.Test.QUnit.TestRunner.Bridge_Collections_ClientTest_Collections_Generic_StackTests);
                t.getFixture().pushWorks();
            },
            clearWorks: function (assert) {
                var t = Bridge.Test.QUnit.TestFixture$1(Bridge.Collections.ClientTest.Collections.Generic.StackTests).beforeTest(true, assert, Bridge.Test.QUnit.TestRunner.Bridge_Collections_ClientTest_Collections_Generic_StackTests);
                t.getFixture().clearWorks();
            },
            containsWorks: function (assert) {
                var t = Bridge.Test.QUnit.TestFixture$1(Bridge.Collections.ClientTest.Collections.Generic.StackTests).beforeTest(true, assert, Bridge.Test.QUnit.TestRunner.Bridge_Collections_ClientTest_Collections_Generic_StackTests);
                t.getFixture().containsWorks();
            },
            containsUsesEqualsMethod: function (assert) {
                var t = Bridge.Test.QUnit.TestFixture$1(Bridge.Collections.ClientTest.Collections.Generic.StackTests).beforeTest(true, assert, Bridge.Test.QUnit.TestRunner.Bridge_Collections_ClientTest_Collections_Generic_StackTests);
                t.getFixture().containsUsesEqualsMethod();
            },
            foreachWithListItemCallbackWorks: function (assert) {
                var t = Bridge.Test.QUnit.TestFixture$1(Bridge.Collections.ClientTest.Collections.Generic.StackTests).beforeTest(true, assert, Bridge.Test.QUnit.TestRunner.Bridge_Collections_ClientTest_Collections_Generic_StackTests);
                t.getFixture().foreachWithListItemCallbackWorks();
            },
            foreachWithListCallbackWorks: function (assert) {
                var t = Bridge.Test.QUnit.TestFixture$1(Bridge.Collections.ClientTest.Collections.Generic.StackTests).beforeTest(true, assert, Bridge.Test.QUnit.TestRunner.Bridge_Collections_ClientTest_Collections_Generic_StackTests);
                t.getFixture().foreachWithListCallbackWorks();
            },
            popWorks: function (assert) {
                var t = Bridge.Test.QUnit.TestFixture$1(Bridge.Collections.ClientTest.Collections.Generic.StackTests).beforeTest(true, assert, Bridge.Test.QUnit.TestRunner.Bridge_Collections_ClientTest_Collections_Generic_StackTests);
                t.getFixture().popWorks();
            },
            peekWorks: function (assert) {
                var t = Bridge.Test.QUnit.TestFixture$1(Bridge.Collections.ClientTest.Collections.Generic.StackTests).beforeTest(true, assert, Bridge.Test.QUnit.TestRunner.Bridge_Collections_ClientTest_Collections_Generic_StackTests);
                t.getFixture().peekWorks();
            },
            toArrayWorks: function (assert) {
                var t = Bridge.Test.QUnit.TestFixture$1(Bridge.Collections.ClientTest.Collections.Generic.StackTests).beforeTest(true, assert, Bridge.Test.QUnit.TestRunner.Bridge_Collections_ClientTest_Collections_Generic_StackTests);
                t.getFixture().toArrayWorks();
            }
        }
    });
    
    Bridge.init();
})(this);
