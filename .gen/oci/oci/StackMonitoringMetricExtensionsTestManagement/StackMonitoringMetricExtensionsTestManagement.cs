using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.StackMonitoringMetricExtensionsTestManagement
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_metric_extensions_test_management oci_stack_monitoring_metric_extensions_test_management}.</summary>
    [JsiiClass(nativeType: typeof(oci.StackMonitoringMetricExtensionsTestManagement.StackMonitoringMetricExtensionsTestManagement), fullyQualifiedName: "oci.stackMonitoringMetricExtensionsTestManagement.StackMonitoringMetricExtensionsTestManagement", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.stackMonitoringMetricExtensionsTestManagement.StackMonitoringMetricExtensionsTestManagementConfig\"}}]")]
    public class StackMonitoringMetricExtensionsTestManagement : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_metric_extensions_test_management oci_stack_monitoring_metric_extensions_test_management} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public StackMonitoringMetricExtensionsTestManagement(Constructs.Construct scope, string id, oci.StackMonitoringMetricExtensionsTestManagement.IStackMonitoringMetricExtensionsTestManagementConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.StackMonitoringMetricExtensionsTestManagement.IStackMonitoringMetricExtensionsTestManagementConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected StackMonitoringMetricExtensionsTestManagement(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected StackMonitoringMetricExtensionsTestManagement(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a StackMonitoringMetricExtensionsTestManagement resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the StackMonitoringMetricExtensionsTestManagement to import.</param>
        /// <param name="importFromId">The id of the existing StackMonitoringMetricExtensionsTestManagement that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the StackMonitoringMetricExtensionsTestManagement to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the StackMonitoringMetricExtensionsTestManagement to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_metric_extensions_test_management#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing StackMonitoringMetricExtensionsTestManagement that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the StackMonitoringMetricExtensionsTestManagement to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.StackMonitoringMetricExtensionsTestManagement.StackMonitoringMetricExtensionsTestManagement), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.stackMonitoringMetricExtensionsTestManagement.StackMonitoringMetricExtensionsTestManagementTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.StackMonitoringMetricExtensionsTestManagement.IStackMonitoringMetricExtensionsTestManagementTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.StackMonitoringMetricExtensionsTestManagement.IStackMonitoringMetricExtensionsTestManagementTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(oci.StackMonitoringMetricExtensionsTestManagement.StackMonitoringMetricExtensionsTestManagement))!;

        [JsiiProperty(name: "testRunId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TestRunId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "testRunMetricSuffix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TestRunMetricSuffix
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "testRunNamespaceName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TestRunNamespaceName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "testRunResourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TestRunResourceGroupName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.stackMonitoringMetricExtensionsTestManagement.StackMonitoringMetricExtensionsTestManagementTimeoutsOutputReference\"}")]
        public virtual oci.StackMonitoringMetricExtensionsTestManagement.StackMonitoringMetricExtensionsTestManagementTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.StackMonitoringMetricExtensionsTestManagement.StackMonitoringMetricExtensionsTestManagementTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "metricExtensionIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MetricExtensionIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceIdsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ResourceIdsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.stackMonitoringMetricExtensionsTestManagement.StackMonitoringMetricExtensionsTestManagementTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "metricExtensionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MetricExtensionId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "resourceIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ResourceIds
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }
    }
}
