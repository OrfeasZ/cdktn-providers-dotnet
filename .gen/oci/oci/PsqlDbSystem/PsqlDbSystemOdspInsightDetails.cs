using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.PsqlDbSystem
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.psqlDbSystem.PsqlDbSystemOdspInsightDetails")]
    public class PsqlDbSystemOdspInsightDetails : oci.PsqlDbSystem.IPsqlDbSystemOdspInsightDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/psql_db_system#kind PsqlDbSystem#kind}.</summary>
        [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}")]
        public string Kind
        {
            get;
            set;
        }

        private object? _odspInsightList;

        /// <summary>odsp_insight_list block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/psql_db_system#odsp_insight_list PsqlDbSystem#odsp_insight_list}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.PsqlDbSystem.IPsqlDbSystemOdspInsightDetailsOdspInsightListStruct" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "odspInsightList", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.psqlDbSystem.PsqlDbSystemOdspInsightDetailsOdspInsightListStruct\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? OdspInsightList
        {
            get => _odspInsightList;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.PsqlDbSystem.IPsqlDbSystemOdspInsightDetailsOdspInsightListStruct[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.PsqlDbSystem.IPsqlDbSystemOdspInsightDetailsOdspInsightListStruct).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _odspInsightList = value;
            }
        }
    }
}
