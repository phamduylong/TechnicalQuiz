function haveSameContents(a, b) {
    const allContents = new Set([...a, ...b]);
    for (const v of allContents)
        if (a.filter(e => e === v).length !== b.filter(e => e === v).length)
            return false;
    return true;
};