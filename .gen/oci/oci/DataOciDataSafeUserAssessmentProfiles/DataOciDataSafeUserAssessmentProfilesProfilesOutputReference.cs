using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDataSafeUserAssessmentProfiles
{
    [JsiiClass(nativeType: typeof(oci.DataOciDataSafeUserAssessmentProfiles.DataOciDataSafeUserAssessmentProfilesProfilesOutputReference), fullyQualifiedName: "oci.dataOciDataSafeUserAssessmentProfiles.DataOciDataSafeUserAssessmentProfilesProfilesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDataSafeUserAssessmentProfilesProfilesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDataSafeUserAssessmentProfilesProfilesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataSafeUserAssessmentProfilesProfilesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataSafeUserAssessmentProfilesProfilesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compositeLimit", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompositeLimit
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "connectTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConnectTime
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cpuPerCall", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CpuPerCall
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cpuPerSession", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CpuPerSession
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "failedLoginAttempts", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FailedLoginAttempts
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "idleTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdleTime
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "inactiveAccountTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InactiveAccountTime
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isUserCreated", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsUserCreated
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "logicalReadsPerCall", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LogicalReadsPerCall
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "logicalReadsPerSession", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LogicalReadsPerSession
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "passwordGraceTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PasswordGraceTime
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "passwordLifeTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PasswordLifeTime
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "passwordLockTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PasswordLockTime
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "passwordReuseMax", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PasswordReuseMax
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "passwordReuseTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PasswordReuseTime
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "passwordRolloverTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PasswordRolloverTime
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "passwordVerificationFunction", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PasswordVerificationFunction
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "passwordVerificationFunctionDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PasswordVerificationFunctionDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "privateSga", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrivateSga
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "profileName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProfileName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sessionsPerUser", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SessionsPerUser
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "targetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "userAssessmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserAssessmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "userCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double UserCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDataSafeUserAssessmentProfiles.DataOciDataSafeUserAssessmentProfilesProfiles\"}", isOptional: true)]
        public virtual oci.DataOciDataSafeUserAssessmentProfiles.IDataOciDataSafeUserAssessmentProfilesProfiles? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDataSafeUserAssessmentProfiles.IDataOciDataSafeUserAssessmentProfilesProfiles?>();
            set => SetInstanceProperty(value);
        }
    }
}
