using GraphQL.Types;

namespace GraphQLNetExample.Documents;

public class InvoicesSchema : Schema
{
  public InvoicesSchema(IServiceProvider serviceProvider) : base(serviceProvider)
  {
    Query = serviceProvider.GetRequiredService<InvoicesQuery>();
  }
}