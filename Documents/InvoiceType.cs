using GraphQL.Types;

namespace GraphQLNetExample.Documents;

public class InvoiceType : ObjectGraphType<Invoice>
{
  public InvoiceType()
  {
    Name = "Invoice";
    Description = "Invoice Type";
    Field(d => d.Id, nullable: false).Description("Document Id");
    Field(d => d.Name, nullable: true).Description("Project Name");
  }
}