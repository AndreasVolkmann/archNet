// ------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// ------------------------------------------------------------------------------

namespace ConsoleApp2.Repository
{
    using ConsoleApp2.Entity;

    public interface IDemoRepository
    {
        DemoEntity Get(string id);
    }
}
