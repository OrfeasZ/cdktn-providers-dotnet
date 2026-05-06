using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciStackMonitoringMaintenanceWindow
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/stack_monitoring_maintenance_window oci_stack_monitoring_maintenance_window}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciStackMonitoringMaintenanceWindow.DataOciStackMonitoringMaintenanceWindow), fullyQualifiedName: "oci.dataOciStackMonitoringMaintenanceWindow.DataOciStackMonitoringMaintenanceWindow", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciStackMonitoringMaintenanceWindow.DataOciStackMonitoringMaintenanceWindowConfig\"}}]")]
    public class DataOciStackMonitoringMaintenanceWindow : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/stack_monitoring_maintenance_window oci_stack_monitoring_maintenance_window} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciStackMonitoringMaintenanceWindow(Constructs.Construct scope, string id, oci.DataOciStackMonitoringMaintenanceWindow.IDataOciStackMonitoringMaintenanceWindowConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciStackMonitoringMaintenanceWindow.IDataOciStackMonitoringMaintenanceWindowConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciStackMonitoringMaintenanceWindow(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciStackMonitoringMaintenanceWindow(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciStackMonitoringMaintenanceWindow resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciStackMonitoringMaintenanceWindow to import.</param>
        /// <param name="importFromId">The id of the existing DataOciStackMonitoringMaintenanceWindow that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciStackMonitoringMaintenanceWindow to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciStackMonitoringMaintenanceWindow to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/stack_monitoring_maintenance_window#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciStackMonitoringMaintenanceWindow that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciStackMonitoringMaintenanceWindow to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciStackMonitoringMaintenanceWindow.DataOciStackMonitoringMaintenanceWindow), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciStackMonitoringMaintenanceWindow.DataOciStackMonitoringMaintenanceWindow))!;

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "resources", typeJson: "{\"fqn\":\"oci.dataOciStackMonitoringMaintenanceWindow.DataOciStackMonitoringMaintenanceWindowResourcesList\"}")]
        public virtual oci.DataOciStackMonitoringMaintenanceWindow.DataOciStackMonitoringMaintenanceWindowResourcesList Resources
        {
            get => GetInstanceProperty<oci.DataOciStackMonitoringMaintenanceWindow.DataOciStackMonitoringMaintenanceWindowResourcesList>()!;
        }

        [JsiiProperty(name: "resourcesDetails", typeJson: "{\"fqn\":\"oci.dataOciStackMonitoringMaintenanceWindow.DataOciStackMonitoringMaintenanceWindowResourcesDetailsList\"}")]
        public virtual oci.DataOciStackMonitoringMaintenanceWindow.DataOciStackMonitoringMaintenanceWindowResourcesDetailsList ResourcesDetails
        {
            get => GetInstanceProperty<oci.DataOciStackMonitoringMaintenanceWindow.DataOciStackMonitoringMaintenanceWindowResourcesDetailsList>()!;
        }

        [JsiiProperty(name: "schedule", typeJson: "{\"fqn\":\"oci.dataOciStackMonitoringMaintenanceWindow.DataOciStackMonitoringMaintenanceWindowScheduleList\"}")]
        public virtual oci.DataOciStackMonitoringMaintenanceWindow.DataOciStackMonitoringMaintenanceWindowScheduleList Schedule
        {
            get => GetInstanceProperty<oci.DataOciStackMonitoringMaintenanceWindow.DataOciStackMonitoringMaintenanceWindowScheduleList>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "systemTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SystemTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "maintenanceWindowIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MaintenanceWindowIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "maintenanceWindowId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaintenanceWindowId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
