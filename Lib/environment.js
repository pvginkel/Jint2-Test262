function fnGlobalObject() {
    return (function () { return this }).call(null);
}
