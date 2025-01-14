// <auto-generated/>
using GitHub.Projects.Columns.Cards;
using GitHub.Projects.Columns.Item;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace GitHub.Projects.Columns {
    /// <summary>
    /// Builds and executes requests for operations under \projects\columns
    /// </summary>
    public class ColumnsRequestBuilder : BaseRequestBuilder {
        /// <summary>The cards property</summary>
        public CardsRequestBuilder Cards { get =>
            new CardsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the GitHub.projects.columns.item collection</summary>
        /// <param name="position">The unique identifier of the column.</param>
        public WithColumn_ItemRequestBuilder this[int position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("column_id", position);
            return new WithColumn_ItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new ColumnsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ColumnsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/projects/columns", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new ColumnsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ColumnsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/projects/columns", rawUrl) {
        }
    }
}
