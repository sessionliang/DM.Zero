﻿using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM.AbpZeroTemplate.CMS.Channels.Dto
{
    public class MoveChannelInput : IInputDto
    {
        /// <summary>
        /// 原来栏目Id
        /// </summary>
        [Range(1, long.MaxValue)]
        public long Id { get; set; }

        /// <summary>
        /// 新的栏目Id
        /// </summary>
        public long? NewParentId { get; set; }
    }
}
