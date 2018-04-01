// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace SimpleNetCoreApiV1Client
{
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for SimpleNetCoreApi.
    /// </summary>
    public static partial class SimpleNetCoreApiExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            public static int? ApiEchoByIdGet(this ISimpleNetCoreApi operations, int id)
            {
                return operations.ApiEchoByIdGetAsync(id).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<int?> ApiEchoByIdGetAsync(this ISimpleNetCoreApi operations, int id, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ApiEchoByIdGetWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='o'>
            /// </param>
            public static object ApiEchoPost(this ISimpleNetCoreApi operations, object o = default(object))
            {
                return operations.ApiEchoPostAsync(o).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='o'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> ApiEchoPostAsync(this ISimpleNetCoreApi operations, object o = default(object), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ApiEchoPostWithHttpMessagesAsync(o, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='message'>
            /// </param>
            public static string ApiLoggingInformationPost(this ISimpleNetCoreApi operations, string message = default(string))
            {
                return operations.ApiLoggingInformationPostAsync(message).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='message'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<string> ApiLoggingInformationPostAsync(this ISimpleNetCoreApi operations, string message = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ApiLoggingInformationPostWithHttpMessagesAsync(message, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='message'>
            /// </param>
            public static string ApiLoggingWarningPost(this ISimpleNetCoreApi operations, string message = default(string))
            {
                return operations.ApiLoggingWarningPostAsync(message).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='message'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<string> ApiLoggingWarningPostAsync(this ISimpleNetCoreApi operations, string message = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ApiLoggingWarningPostWithHttpMessagesAsync(message, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='message'>
            /// </param>
            public static string ApiLoggingErrorPost(this ISimpleNetCoreApi operations, string message = default(string))
            {
                return operations.ApiLoggingErrorPostAsync(message).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='message'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<string> ApiLoggingErrorPostAsync(this ISimpleNetCoreApi operations, string message = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ApiLoggingErrorPostWithHttpMessagesAsync(message, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IList<ModelDto> ApiModelsGet(this ISimpleNetCoreApi operations)
            {
                return operations.ApiModelsGetAsync().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<ModelDto>> ApiModelsGetAsync(this ISimpleNetCoreApi operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ApiModelsGetWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='dto'>
            /// </param>
            public static void ApiModelsPost(this ISimpleNetCoreApi operations, ModelDto dto = default(ModelDto))
            {
                operations.ApiModelsPostAsync(dto).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='dto'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ApiModelsPostAsync(this ISimpleNetCoreApi operations, ModelDto dto = default(ModelDto), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.ApiModelsPostWithHttpMessagesAsync(dto, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            public static ModelDto ApiModelsByIdGet(this ISimpleNetCoreApi operations, int id)
            {
                return operations.ApiModelsByIdGetAsync(id).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ModelDto> ApiModelsByIdGetAsync(this ISimpleNetCoreApi operations, int id, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ApiModelsByIdGetWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='dto'>
            /// </param>
            public static void ApiModelsByIdPut(this ISimpleNetCoreApi operations, int id, ModelDto dto = default(ModelDto))
            {
                operations.ApiModelsByIdPutAsync(id, dto).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='dto'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ApiModelsByIdPutAsync(this ISimpleNetCoreApi operations, int id, ModelDto dto = default(ModelDto), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.ApiModelsByIdPutWithHttpMessagesAsync(id, dto, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            public static ModelDto ApiModelsByIdDelete(this ISimpleNetCoreApi operations, int id)
            {
                return operations.ApiModelsByIdDeleteAsync(id).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ModelDto> ApiModelsByIdDeleteAsync(this ISimpleNetCoreApi operations, int id, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ApiModelsByIdDeleteWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IList<string> ApiValuesGet(this ISimpleNetCoreApi operations)
            {
                return operations.ApiValuesGetAsync().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<string>> ApiValuesGetAsync(this ISimpleNetCoreApi operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ApiValuesGetWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            public static string ApiValuesByIdGet(this ISimpleNetCoreApi operations, int id)
            {
                return operations.ApiValuesByIdGetAsync(id).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<string> ApiValuesByIdGetAsync(this ISimpleNetCoreApi operations, int id, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ApiValuesByIdGetWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
