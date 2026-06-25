using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseDataPatch
{
    [JsiiInterface(nativeType: typeof(IDatabaseDataPatchDataPatchOptions), fullyQualifiedName: "oci.databaseDataPatch.DatabaseDataPatchDataPatchOptions")]
    public interface IDatabaseDataPatchDataPatchOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/database_data_patch#should_skip_closed_pdbs DatabaseDataPatch#should_skip_closed_pdbs}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "shouldSkipClosedPdbs", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ShouldSkipClosedPdbs
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseDataPatchDataPatchOptions), fullyQualifiedName: "oci.databaseDataPatch.DatabaseDataPatchDataPatchOptions")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseDataPatch.IDatabaseDataPatchDataPatchOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/database_data_patch#should_skip_closed_pdbs DatabaseDataPatch#should_skip_closed_pdbs}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "shouldSkipClosedPdbs", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ShouldSkipClosedPdbs
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
