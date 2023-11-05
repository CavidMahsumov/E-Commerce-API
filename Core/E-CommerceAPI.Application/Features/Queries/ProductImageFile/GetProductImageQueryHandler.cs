using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceAPI.Application.Features.Queries.ProductImageFile
{
    public class GetProductImageQueryHandler : IRequestHandler<GetProductImageQueryRequest, GetProductImageQueryResponse>
    {
        public async Task<GetProductImageQueryResponse> Handle(GetProductImageQueryRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
