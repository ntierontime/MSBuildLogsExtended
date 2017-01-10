using System;
using System.Reflection;

namespace MSBuildLogsExtended.AspNetMvc50WebApi2.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}