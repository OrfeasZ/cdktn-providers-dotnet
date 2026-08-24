using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareMoqRelay
{
    [JsiiByValue(fqn: "cloudflare.dataCloudflareMoqRelay.DataCloudflareMoqRelayFilter")]
    public class DataCloudflareMoqRelayFilter : cloudflare.DataCloudflareMoqRelay.IDataCloudflareMoqRelayFilter
    {
        private object? _asc;

        /// <summary>Sort order by `created`. When true, results are returned oldest-first (ascending); otherwise newest-first (descending, the default).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/data-sources/moq_relay#asc DataCloudflareMoqRelay#asc}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "asc", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Asc
        {
            get => _asc;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _asc = value;
            }
        }

        /// <summary>Cursor for pagination.</summary>
        /// <remarks>
        /// Returns relays created strictly after this
        /// RFC 3339 timestamp (typically the <c>created</c> value of the last item
        /// on the current page, to fetch the next page).
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/data-sources/moq_relay#created_after DataCloudflareMoqRelay#created_after}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "createdAfter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CreatedAfter
        {
            get;
            set;
        }

        /// <summary>Cursor for pagination.</summary>
        /// <remarks>
        /// Returns relays created strictly before this
        /// RFC 3339 timestamp (typically the <c>created</c> value of the first item
        /// on the current page, to fetch the previous page).
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/data-sources/moq_relay#created_before DataCloudflareMoqRelay#created_before}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "createdBefore", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CreatedBefore
        {
            get;
            set;
        }

        /// <summary>Maximum number of relays to return per page. Values above the maximum are clamped to it rather than rejected.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.24.0/docs/data-sources/moq_relay#per_page DataCloudflareMoqRelay#per_page}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "perPage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? PerPage
        {
            get;
            set;
        }
    }
}
