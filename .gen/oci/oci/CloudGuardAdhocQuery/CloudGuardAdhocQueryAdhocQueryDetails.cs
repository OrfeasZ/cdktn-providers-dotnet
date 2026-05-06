using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudGuardAdhocQuery
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.cloudGuardAdhocQuery.CloudGuardAdhocQueryAdhocQueryDetails")]
    public class CloudGuardAdhocQueryAdhocQueryDetails : oci.CloudGuardAdhocQuery.ICloudGuardAdhocQueryAdhocQueryDetails
    {
        private object _adhocQueryResources;

        /// <summary>adhoc_query_resources block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_adhoc_query#adhoc_query_resources CloudGuardAdhocQuery#adhoc_query_resources}
        /// </remarks>
        [JsiiProperty(name: "adhocQueryResources", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.cloudGuardAdhocQuery.CloudGuardAdhocQueryAdhocQueryDetailsAdhocQueryResources\"},\"kind\":\"array\"}}]}}")]
        public object AdhocQueryResources
        {
            get => _adhocQueryResources;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.CloudGuardAdhocQuery.ICloudGuardAdhocQueryAdhocQueryDetailsAdhocQueryResources[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.CloudGuardAdhocQuery.ICloudGuardAdhocQueryAdhocQueryDetailsAdhocQueryResources).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.CloudGuardAdhocQuery.ICloudGuardAdhocQueryAdhocQueryDetailsAdhocQueryResources).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _adhocQueryResources = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_guard_adhoc_query#query CloudGuardAdhocQuery#query}.</summary>
        [JsiiProperty(name: "query", typeJson: "{\"primitive\":\"string\"}")]
        public string Query
        {
            get;
            set;
        }
    }
}
