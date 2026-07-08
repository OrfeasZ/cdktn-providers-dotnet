using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.PsqlDbSystem
{
    [JsiiInterface(nativeType: typeof(IPsqlDbSystemOdspInsightDetails), fullyQualifiedName: "oci.psqlDbSystem.PsqlDbSystemOdspInsightDetails")]
    public interface IPsqlDbSystemOdspInsightDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/psql_db_system#kind PsqlDbSystem#kind}.</summary>
        [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}")]
        string Kind
        {
            get;
        }

        /// <summary>odsp_insight_list block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/psql_db_system#odsp_insight_list PsqlDbSystem#odsp_insight_list}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.PsqlDbSystem.IPsqlDbSystemOdspInsightDetailsOdspInsightListStruct" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "odspInsightList", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.psqlDbSystem.PsqlDbSystemOdspInsightDetailsOdspInsightListStruct\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? OdspInsightList
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPsqlDbSystemOdspInsightDetails), fullyQualifiedName: "oci.psqlDbSystem.PsqlDbSystemOdspInsightDetails")]
        internal sealed class _Proxy : DeputyBase, oci.PsqlDbSystem.IPsqlDbSystemOdspInsightDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/psql_db_system#kind PsqlDbSystem#kind}.</summary>
            [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}")]
            public string Kind
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>odsp_insight_list block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/psql_db_system#odsp_insight_list PsqlDbSystem#odsp_insight_list}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.PsqlDbSystem.IPsqlDbSystemOdspInsightDetailsOdspInsightListStruct" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "odspInsightList", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.psqlDbSystem.PsqlDbSystemOdspInsightDetailsOdspInsightListStruct\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? OdspInsightList
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
