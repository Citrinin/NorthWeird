// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace NorthWeird.WebApiTests
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Products.
    /// </summary>
    public static partial class ProductsExtensions
    {
            /// <summary>
            /// Retrieves a product list that contains full list of products
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static void GET(this IProducts operations)
            {
                operations.GETAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieves a product list that contains full list of products
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task GETAsync(this IProducts operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.GETWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Creates product from request body
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='product'>
            /// Product that needs to be created
            /// </param>
            public static void POST(this IProducts operations, ProductDto product = default(ProductDto))
            {
                operations.POSTAsync(product).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates product from request body
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='product'>
            /// Product that needs to be created
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task POSTAsync(this IProducts operations, ProductDto product = default(ProductDto), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.POSTWithHttpMessagesAsync(product, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Retrieves a specific product by unique id
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Id of the product
            /// </param>
            public static void GET1(this IProducts operations, int id)
            {
                operations.GET1Async(id).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieves a specific product by unique id
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Id of the product
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task GET1Async(this IProducts operations, int id, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.GET1WithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Updates product from request body
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// id of the product that needs to be updated
            /// </param>
            /// <param name='product'>
            /// Product that needs to be updated
            /// </param>
            public static void PUT(this IProducts operations, int id, ProductDto product = default(ProductDto))
            {
                operations.PUTAsync(id, product).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates product from request body
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// id of the product that needs to be updated
            /// </param>
            /// <param name='product'>
            /// Product that needs to be updated
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PUTAsync(this IProducts operations, int id, ProductDto product = default(ProductDto), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.PUTWithHttpMessagesAsync(id, product, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Deletes product from request body
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// id of the product that needs to be deleted
            /// </param>
            public static void DELETE(this IProducts operations, int id)
            {
                operations.DELETEAsync(id).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes product from request body
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// id of the product that needs to be deleted
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DELETEAsync(this IProducts operations, int id, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DELETEWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
