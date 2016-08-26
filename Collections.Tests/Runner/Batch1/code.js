Bridge.initAssembly("Bridge.Collections.ClientTest", function ($asm, globals) {
    "use strict";

    Bridge.define('Bridge.Collections.ClientTest.BridgeIssues.Bridge634', {
        statics: {
            testUseCase1: function () {
                var $t;
                var hashSet = new (System.Collections.Generic.HashSet$1(String)).$constructor();

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

    Bridge.define('Bridge.Collections.ClientTest.Collections.Generic.StackTests', {
        getStack: function () {
            return new (System.Collections.Generic.Stack$1(String)).$constructor1(["x", "y"]);
        },
        getArray: function () {
            return [8, 7, 4, 1];
        },
        getReversedArray: function () {
            return [1, 4, 7, 8];
        },
        typePropertiesAreCorrect: function () {
            Bridge.Test.Assert.areEqual$1("System.Collections.Generic.List$1[[System.Int32, mscorlib]]", Bridge.getTypeName(System.Collections.Generic.List$1(System.Int32)), "GetClassName()");
            var stack = new (System.Collections.Generic.Stack$1(System.Int32)).$constructor();
            Bridge.Test.Assert.true$1(Bridge.is(stack, System.Collections.Generic.Stack$1(System.Int32)), "is Stack<int> should be true");
            Bridge.Test.Assert.true$1(Bridge.is(stack, System.Collections.ICollection), "is ICollection<int> should be true");
            Bridge.Test.Assert.true$1(Bridge.is(stack, System.Collections.Generic.IEnumerable$1(System.Int32)), "is IEnumerable<int> should be true");
        },
        defaultConstructorWorks: function () {
            var l = new (System.Collections.Generic.Stack$1(System.Int32)).$constructor();
            Bridge.Test.Assert.areEqual(0, l.getCount());
        },
        constructorWithCapacityWorks: function () {
            var l = new (System.Collections.Generic.Stack$1(System.Int32)).$constructor2(12);
            Bridge.Test.Assert.areEqual(0, l.getCount());
        },
        constructingFromArrayWorks: function () {
            var arr = this.getArray();
            var l = new (System.Collections.Generic.Stack$1(System.Int32)).$constructor1(arr);
            Bridge.Test.Assert.false(Bridge.referenceEquals(l, arr));
            Bridge.Test.Assert.areDeepEqual(this.getReversedArray(), l.toArray());
        },
        constructingFromListWorks: function () {
            var arr = new (System.Collections.Generic.Stack$1(System.Int32)).$constructor1(this.getArray());
            var l = new (System.Collections.Generic.Stack$1(System.Int32)).$constructor1(arr);
            Bridge.Test.Assert.false(Bridge.referenceEquals(l, arr));
            Bridge.Test.Assert.areDeepEqual(this.getArray(), l.toArray());
        },
        constructingFromIEnumerableWorks: function () {
            var enm = Bridge.cast(new (System.Collections.Generic.Stack$1(System.Int32)).$constructor1(this.getArray()), System.Collections.Generic.IEnumerable$1(System.Int32));
            var l = new (System.Collections.Generic.List$1(System.Int32))(enm);
            Bridge.Test.Assert.false(Bridge.referenceEquals(l, enm));
            Bridge.Test.Assert.areDeepEqual(this.getReversedArray(), l.toArray());
        },
        countWorks: function () {
            Bridge.Test.Assert.areEqual(0, new (System.Collections.Generic.Stack$1(String)).$constructor().getCount());
            Bridge.Test.Assert.areEqual(1, new (System.Collections.Generic.Stack$1(String)).$constructor1(["x"]).getCount());
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
            Bridge.Test.Assert.areDeepEqual(["a", "y", "x"], l.toArray());
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
            var l = new (System.Collections.Generic.Stack$1(Bridge.Collections.ClientTest.Collections.Generic.StackTests.C)).$constructor1([new Bridge.Collections.ClientTest.Collections.Generic.StackTests.C(1), new Bridge.Collections.ClientTest.Collections.Generic.StackTests.C(2), new Bridge.Collections.ClientTest.Collections.Generic.StackTests.C(3)]);
            Bridge.Test.Assert.true(l.contains(new Bridge.Collections.ClientTest.Collections.Generic.StackTests.C(2)));
            Bridge.Test.Assert.false(l.contains(new Bridge.Collections.ClientTest.Collections.Generic.StackTests.C(4)));
        },
        foreachWithListItemCallbackWorks: function () {
            var result = "";
            Bridge.Linq.Enumerable.from(new (System.Collections.Generic.Stack$1(String)).$constructor1(["a", "b", "c"])).forEach(function (s) {
                result += s;
            });
            Bridge.Test.Assert.areEqual("cba", result);
        },
        foreachWithListCallbackWorks: function () {
            var result = "";
            Bridge.Linq.Enumerable.from(new (System.Collections.Generic.Stack$1(String)).$constructor1(["a", "b", "c"])).forEach(function (s, i) {
                result += System.String.concat(s, i);
            });
            Bridge.Test.Assert.areEqual("c0b1a2", result);
        },
        popWorks: function () {
            var list = this.getStack();
            Bridge.Test.Assert.areEqual("y", list.pop());
            Bridge.Test.Assert.areDeepEqual(["x"], list.toArray());
        },
        peekWorks: function () {
            var list = this.getStack();
            Bridge.Test.Assert.areEqual("y", list.peek());
            Bridge.Test.Assert.areDeepEqual(["y", "x"], list.toArray());
        },
        toArrayWorks: function () {
            var l = new (System.Collections.Generic.Stack$1(String)).$constructor();
            l.push("a");
            l.push("b");

            var actual = l.toArray();

            Bridge.Test.Assert.false(Bridge.referenceEquals(l, actual));
            Bridge.Test.Assert.true(Bridge.is(actual, Array));
            Bridge.Test.Assert.areDeepEqual(["b", "a"], actual);
        }
    });

    Bridge.define('Bridge.Collections.ClientTest.Collections.Generic.StackTests.C', {
        i: 0,
        constructor: function (i) {
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

    Bridge.define('Bridge.Collections.ClientTest.Constants', {
        statics: {
            BRIDGE_ISSUES: "Bridge Issues",
            COLLECTIONS: "Collections"
        }
    });

    Bridge.init();
});
