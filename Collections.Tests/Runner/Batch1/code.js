/**
 * Bridge.Collections test library
 * @author Object.NET, Inc.
 * @copyright Copyright 2008-2016 Object.NET, Inc.
 * @compiler Bridge.NET 15.7.0
 */
Bridge.assembly("Bridge.Collections.ClientTest", function ($asm, globals) {
    "use strict";

    Bridge.define("Bridge.Collections.ClientTest.BridgeIssues.Bridge634", {
        statics: {
            testUseCase1: function () {
                var $t;
                var hashSet = new (System.Collections.Generic.HashSet$1(String)).ctor();

                hashSet.add("a");
                hashSet.add("b");
                hashSet.add("c");

                var text = "";

                $t = Bridge.getEnumerator(hashSet);
                while ($t.moveNext()) {
                    var s = $t.getCurrent();
                    text = System.String.concat(text, s);
                }

                Bridge.Test.Assert.areEqual$1("abc", text, "Bridge634: foreach works for HashSet");
            }
        }
    });

    Bridge.define("Bridge.Collections.ClientTest.Collections.Generic.QueueTests", {
        typePropertiesAreCorrect: function () {
            Bridge.Test.Assert.areEqual$1("System.Collections.Generic.Queue$1[[System.Int32, mscorlib]]", Bridge.Reflection.getTypeFullName(System.Collections.Generic.Queue$1(System.Int32)), "FullName should be Array");
            Bridge.Test.Assert.true$1(Bridge.Reflection.isClass(System.Collections.Generic.Queue$1(System.Int32)), "IsClass should be true");
            var list = new (System.Collections.Generic.Queue$1(System.Int32)).ctor();
            Bridge.Test.Assert.true$1(Bridge.is(list, System.Collections.Generic.Queue$1(System.Int32)), "is Queue<int> should be true");
        },
        countWorks: function () {
            var q = new (System.Collections.Generic.Queue$1(System.Int32)).ctor();
            Bridge.Test.Assert.areEqual(0, q.getCount());
            q.enqueue(1);
            Bridge.Test.Assert.areEqual(1, q.getCount());
            q.enqueue(10);
            Bridge.Test.Assert.areEqual(2, q.getCount());
        },
        enqueueAndDequeueWork: function () {
            var q = new (System.Collections.Generic.Queue$1(System.Int32)).ctor();
            q.enqueue(10);
            q.enqueue(2);
            q.enqueue(4);
            Bridge.Test.Assert.areEqual(10, q.dequeue());
            Bridge.Test.Assert.areEqual(2, q.dequeue());
            Bridge.Test.Assert.areEqual(4, q.dequeue());
        },
        peekWorks: function () {
            var q = new (System.Collections.Generic.Queue$1(System.Int32)).ctor();
            q.enqueue(10);
            Bridge.Test.Assert.areEqual(10, q.peek());
            q.enqueue(2);
            Bridge.Test.Assert.areEqual(10, q.peek());
            q.dequeue();
            Bridge.Test.Assert.areEqual(2, q.peek());
        },
        containsWorks: function () {
            var q = new (System.Collections.Generic.Queue$1(System.Int32)).ctor();
            q.enqueue(10);
            q.enqueue(2);
            q.enqueue(4);
            Bridge.Test.Assert.true(q.contains(10));
            Bridge.Test.Assert.true(q.contains(2));
            Bridge.Test.Assert.false(q.contains(11));
        },
        containsUsesEqualsMethod: function () {
            var q = new (System.Collections.Generic.Queue$1(Bridge.Collections.ClientTest.Collections.Generic.QueueTests.C)).ctor();
            q.enqueue(new Bridge.Collections.ClientTest.Collections.Generic.QueueTests.C(1));
            q.enqueue(new Bridge.Collections.ClientTest.Collections.Generic.QueueTests.C(2));
            q.enqueue(new Bridge.Collections.ClientTest.Collections.Generic.QueueTests.C(3));
            Bridge.Test.Assert.true(q.contains(new Bridge.Collections.ClientTest.Collections.Generic.QueueTests.C(2)));
            Bridge.Test.Assert.false(q.contains(new Bridge.Collections.ClientTest.Collections.Generic.QueueTests.C(4)));
        },
        clearWorks: function () {
            var q = new (System.Collections.Generic.Queue$1(System.Int32)).ctor();
            q.enqueue(10);
            q.enqueue(2);
            q.enqueue(4);
            q.clear();
            Bridge.Test.Assert.areEqual(0, q.getCount());
        }
    });

    Bridge.define("Bridge.Collections.ClientTest.Collections.Generic.QueueTests.C", {
        i: 0,
        ctor: function (i) {
            this.$initialize();
            this.i = i;
        },
        equals: function (o) {
            return Bridge.is(o, Bridge.Collections.ClientTest.Collections.Generic.QueueTests.C) && this.i === Bridge.cast(o, Bridge.Collections.ClientTest.Collections.Generic.QueueTests.C).i;
        },
        getHashCode: function () {
            return this.i;
        }
    });

    Bridge.define("Bridge.Collections.ClientTest.Collections.Generic.StackTests", {
        getStack: function () {
            return new (System.Collections.Generic.Stack$1(String)).$ctor1(System.Array.init(["x", "y"], String));
        },
        getArray: function () {
            return System.Array.init([8, 7, 4, 1], System.Int32);
        },
        getReversedArray: function () {
            return System.Array.init([1, 4, 7, 8], System.Int32);
        },
        typePropertiesAreCorrect: function () {
            Bridge.Test.Assert.areEqual$1("System.Collections.Generic.List$1[[System.Int32, mscorlib]]", Bridge.Reflection.getTypeFullName(System.Collections.Generic.List$1(System.Int32)), "FullName");
            var stack = new (System.Collections.Generic.Stack$1(System.Int32)).ctor();
            Bridge.Test.Assert.true$1(Bridge.is(stack, System.Collections.Generic.Stack$1(System.Int32)), "is Stack<int> should be true");
            Bridge.Test.Assert.true$1(Bridge.is(stack, System.Collections.ICollection), "is ICollection<int> should be true");
            Bridge.Test.Assert.true$1(Bridge.is(stack, System.Collections.Generic.IEnumerable$1(System.Int32)), "is IEnumerable<int> should be true");
        },
        defaultConstructorWorks: function () {
            var l = new (System.Collections.Generic.Stack$1(System.Int32)).ctor();
            Bridge.Test.Assert.areEqual(0, l.getCount());
        },
        constructorWithCapacityWorks: function () {
            var l = new (System.Collections.Generic.Stack$1(System.Int32)).$ctor2(12);
            Bridge.Test.Assert.areEqual(0, l.getCount());
        },
        constructingFromArrayWorks: function () {
            var arr = this.getArray();
            var l = new (System.Collections.Generic.Stack$1(System.Int32)).$ctor1(arr);
            Bridge.Test.Assert.false(Bridge.referenceEquals(l, arr));
            Bridge.Test.Assert.areDeepEqual(this.getReversedArray(), l.toArray());
        },
        constructingFromListWorks: function () {
            var arr = new (System.Collections.Generic.Stack$1(System.Int32)).$ctor1(this.getArray());
            var l = new (System.Collections.Generic.Stack$1(System.Int32)).$ctor1(arr);
            Bridge.Test.Assert.false(Bridge.referenceEquals(l, arr));
            Bridge.Test.Assert.areDeepEqual(this.getArray(), l.toArray());
        },
        constructingFromIEnumerableWorks: function () {
            var enm = Bridge.cast(new (System.Collections.Generic.Stack$1(System.Int32)).$ctor1(this.getArray()), System.Collections.Generic.IEnumerable$1(System.Int32));
            var l = new (System.Collections.Generic.List$1(System.Int32))(enm);
            Bridge.Test.Assert.false(Bridge.referenceEquals(l, enm));
            Bridge.Test.Assert.areDeepEqual(this.getReversedArray(), l.toArray());
        },
        countWorks: function () {
            Bridge.Test.Assert.areEqual(0, new (System.Collections.Generic.Stack$1(String)).ctor().getCount());
            Bridge.Test.Assert.areEqual(1, new (System.Collections.Generic.Stack$1(String)).$ctor1(System.Array.init(["x"], String)).getCount());
            Bridge.Test.Assert.areEqual(2, this.getStack().getCount());
        },
        foreachWorks: function () {
            var $t;
            var result = "";
            $t = Bridge.getEnumerator(this.getStack());
            while ($t.moveNext()) {
                var s = $t.getCurrent();
                result += s;
            }
            Bridge.Test.Assert.areEqual("yx", result);
        },
        pushWorks: function () {
            var l = this.getStack();
            l.push("a");
            Bridge.Test.Assert.areDeepEqual(System.Array.init(["a", "y", "x"], String), l.toArray());
        },
        clearWorks: function () {
            var l = this.getStack();
            l.clear();
            Bridge.Test.Assert.areEqual(l.getCount(), 0);
        },
        containsWorks: function () {
            var list = this.getStack();
            Bridge.Test.Assert.true(list.contains("x"));
            Bridge.Test.Assert.false(list.contains("z"));
        },
        containsUsesEqualsMethod: function () {
            var l = new (System.Collections.Generic.Stack$1(Bridge.Collections.ClientTest.Collections.Generic.StackTests.C)).$ctor1(System.Array.init([new Bridge.Collections.ClientTest.Collections.Generic.StackTests.C(1), new Bridge.Collections.ClientTest.Collections.Generic.StackTests.C(2), new Bridge.Collections.ClientTest.Collections.Generic.StackTests.C(3)], Bridge.Collections.ClientTest.Collections.Generic.StackTests.C));
            Bridge.Test.Assert.true(l.contains(new Bridge.Collections.ClientTest.Collections.Generic.StackTests.C(2)));
            Bridge.Test.Assert.false(l.contains(new Bridge.Collections.ClientTest.Collections.Generic.StackTests.C(4)));
        },
        foreachWithListItemCallbackWorks: function () {
            var result = "";
            Bridge.Linq.Enumerable.from(new (System.Collections.Generic.Stack$1(String)).$ctor1(System.Array.init(["a", "b", "c"], String))).forEach(function (s) {
                    result += s;
                });
            Bridge.Test.Assert.areEqual("cba", result);
        },
        foreachWithListCallbackWorks: function () {
            var result = "";
            Bridge.Linq.Enumerable.from(new (System.Collections.Generic.Stack$1(String)).$ctor1(System.Array.init(["a", "b", "c"], String))).forEach(function (s, i) {
                    result += System.String.concat(s, i);
                });
            Bridge.Test.Assert.areEqual("c0b1a2", result);
        },
        popWorks: function () {
            var list = this.getStack();
            Bridge.Test.Assert.areEqual("y", list.pop());
            Bridge.Test.Assert.areDeepEqual(System.Array.init(["x"], String), list.toArray());
        },
        peekWorks: function () {
            var list = this.getStack();
            Bridge.Test.Assert.areEqual("y", list.peek());
            Bridge.Test.Assert.areDeepEqual(System.Array.init(["y", "x"], String), list.toArray());
        },
        toArrayWorks: function () {
            var l = new (System.Collections.Generic.Stack$1(String)).ctor();
            l.push("a");
            l.push("b");

            var actual = l.toArray();

            Bridge.Test.Assert.false(Bridge.referenceEquals(l, actual));
            Bridge.Test.Assert.true(Bridge.is(actual, Array));
            Bridge.Test.Assert.areDeepEqual(System.Array.init(["b", "a"], String), actual);
        }
    });

    Bridge.define("Bridge.Collections.ClientTest.Collections.Generic.StackTests.C", {
        i: 0,
        ctor: function (i) {
            this.$initialize();
            this.i = i;
        },
        equals: function (o) {
            return Bridge.is(o, Bridge.Collections.ClientTest.Collections.Generic.StackTests.C) && this.i === Bridge.cast(o, Bridge.Collections.ClientTest.Collections.Generic.StackTests.C).i;
        },
        getHashCode: function () {
            return this.i;
        }
    });

    Bridge.define("Bridge.Collections.ClientTest.Constants", {
        statics: {
            BRIDGE_ISSUES: "Bridge Issues",
            COLLECTIONS: "Collections"
        }
    });
});
