using GraphQL.Types;

namespace GraphQLNetExample.Documents;

public class InvoicesQuery : ObjectGraphType
{
  public InvoicesQuery()
  {
    Field<ListGraphType<InvoiceType>>("invoices", resolve: context => new List<Invoice> {
      new Invoice { Id = 0, Name = "My First Invoice!" },
      new Invoice { Id = 0, Name = "Second Invoice?" }
    });
  }
}