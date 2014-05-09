// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Reflection;

namespace Microsoft.AspNet.Mvc
{
    public interface IActionDiscoveryConventions
    {
        bool IsController(TypeInfo typeInfo);

        IEnumerable<ActionInfo> GetActions(MethodInfo methodInfo, TypeInfo controllerTypeInfo);
    }
}
