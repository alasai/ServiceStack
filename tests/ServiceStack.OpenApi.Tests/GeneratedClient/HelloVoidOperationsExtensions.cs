// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace AutorestClient
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for HelloVoidOperations.
    /// </summary>
    public static partial class HelloVoidOperationsExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='name'>
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='format'>
            /// Specifies response output format
            /// </param>
            public static object Get(this IHelloVoidOperations operations, string name = default(string), HelloVoid body = default(HelloVoid), string format = "json")
            {
                return operations.GetAsync(name, body, format).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='name'>
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='format'>
            /// Specifies response output format
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> GetAsync(this IHelloVoidOperations operations, string name = default(string), HelloVoid body = default(HelloVoid), string format = "json", CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(name, body, format, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='name'>
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='format'>
            /// Specifies response output format
            /// </param>
            public static object Create(this IHelloVoidOperations operations, string name = default(string), HelloVoid body = default(HelloVoid), string format = "json")
            {
                return operations.CreateAsync(name, body, format).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='name'>
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='format'>
            /// Specifies response output format
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> CreateAsync(this IHelloVoidOperations operations, string name = default(string), HelloVoid body = default(HelloVoid), string format = "json", CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(name, body, format, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='name'>
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='format'>
            /// Specifies response output format
            /// </param>
            public static object Post(this IHelloVoidOperations operations, string name = default(string), HelloVoid body = default(HelloVoid), string format = "json")
            {
                return operations.PostAsync(name, body, format).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='name'>
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='format'>
            /// Specifies response output format
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> PostAsync(this IHelloVoidOperations operations, string name = default(string), HelloVoid body = default(HelloVoid), string format = "json", CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PostWithHttpMessagesAsync(name, body, format, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='name'>
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='format'>
            /// Specifies response output format
            /// </param>
            public static object Delete(this IHelloVoidOperations operations, string name = default(string), HelloVoid body = default(HelloVoid), string format = "json")
            {
                return operations.DeleteAsync(name, body, format).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='name'>
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='format'>
            /// Specifies response output format
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> DeleteAsync(this IHelloVoidOperations operations, string name = default(string), HelloVoid body = default(HelloVoid), string format = "json", CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteWithHttpMessagesAsync(name, body, format, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='name'>
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='format'>
            /// Specifies response output format
            /// </param>
            public static object Update(this IHelloVoidOperations operations, string name = default(string), HelloVoid body = default(HelloVoid), string format = "json")
            {
                return operations.UpdateAsync(name, body, format).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='name'>
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='format'>
            /// Specifies response output format
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> UpdateAsync(this IHelloVoidOperations operations, string name = default(string), HelloVoid body = default(HelloVoid), string format = "json", CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(name, body, format, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
