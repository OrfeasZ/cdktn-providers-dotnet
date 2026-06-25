using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseAutonomousDatabase
{
    [JsiiClass(nativeType: typeof(oci.DatabaseAutonomousDatabase.DatabaseAutonomousDatabaseTransportableTablespaceOutputReference), fullyQualifiedName: "oci.databaseAutonomousDatabase.DatabaseAutonomousDatabaseTransportableTablespaceOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DatabaseAutonomousDatabaseTransportableTablespaceOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DatabaseAutonomousDatabaseTransportableTablespaceOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseAutonomousDatabaseTransportableTablespaceOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseAutonomousDatabaseTransportableTablespaceOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "ttsBundleUrlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TtsBundleUrlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "ttsBundleUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TtsBundleUrl
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.databaseAutonomousDatabase.DatabaseAutonomousDatabaseTransportableTablespace\"}", isOptional: true)]
        public virtual oci.DatabaseAutonomousDatabase.IDatabaseAutonomousDatabaseTransportableTablespace? InternalValue
        {
            get => GetInstanceProperty<oci.DatabaseAutonomousDatabase.IDatabaseAutonomousDatabaseTransportableTablespace?>();
            set => SetInstanceProperty(value);
        }
    }
}
